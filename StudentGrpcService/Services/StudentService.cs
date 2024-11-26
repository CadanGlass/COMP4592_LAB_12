using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using StudentGrpcService.Data;
using SchoolLibrary;

namespace StudentGrpcService.Services;

public class StudentService : StudentRemote.StudentRemote.StudentRemoteBase
{
    private readonly SchoolDbContext _context;

    public StudentService(SchoolDbContext context)
    {
        _context = context;
    }

    public override async Task<StudentRemote.StudentList> GetAllStudents(Empty request, ServerCallContext context)
    {
        var students = await _context.Students.ToListAsync();
        var response = new StudentRemote.StudentList();
        response.Students.AddRange(students.Select(s => new StudentRemote.Student
        {
            Id = s.StudentId,
            Name = $"{s.FirstName} {s.LastName}",
            Program = s.School ?? string.Empty
        }));
        return response;
    }

    public override async Task<StudentRemote.Student> AddStudent(StudentRemote.Student request, ServerCallContext context)
    {
        var nameParts = request.Name.Split(' ', 2);
        var student = new SchoolLibrary.Student
        {
            FirstName = nameParts.Length > 0 ? nameParts[0] : "",
            LastName = nameParts.Length > 1 ? nameParts[1] : "",
            School = request.Program
        };

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        request.Id = student.StudentId;
        return request;
    }

    public override async Task<StudentRemote.Student> UpdateStudent(StudentRemote.Student request, ServerCallContext context)
    {
        var student = await _context.Students.FindAsync(request.Id);
        if (student == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "Student not found"));
        }

        var nameParts = request.Name.Split(' ', 2);
        student.FirstName = nameParts.Length > 0 ? nameParts[0] : "";
        student.LastName = nameParts.Length > 1 ? nameParts[1] : "";
        student.School = request.Program;

        await _context.SaveChangesAsync();

        return request;
    }

    public override async Task<Empty> DeleteStudent(StudentRemote.StudentLookupModel request, ServerCallContext context)
    {
        var student = await _context.Students.FindAsync(request.Id);
        if (student == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "Student not found"));
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return new Empty();
    }
} 