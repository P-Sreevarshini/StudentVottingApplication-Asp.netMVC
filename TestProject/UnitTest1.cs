using NUnit.Framework;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Dotnet_M1_A2.Models;
using Dotnet_M1_A2.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using Moq;

namespace TestProject;


public class Tests
{
    private AppDbContext _context;


    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "Dotnet_M1_A2")
                    .Options;
        _context = new AppDbContext(options);
        _context.Database.EnsureDeleted();
    _context.Database.EnsureCreated();

    }

    [Test]
    public void Student_Models_ClassExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Student";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentType = assembly.GetType(typeName);
        Assert.IsNotNull(StudentType);
    }
    [Test]
    public void Position_Models_ClassExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        Assert.IsNotNull(PositionType);
    }
    [Test]
    public void Vote_Models_ClassExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Vote";
        Assembly assembly = Assembly.Load(assemblyName);
        Type VoteType = assembly.GetType(typeName);
        Assert.IsNotNull(VoteType);
    }

    [Test]
    public void Student_StudentID_PropertyExists_ReturnExpectedDataTypes_int()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Student";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = StudentType.GetProperty("StudentID");
        Assert.IsNotNull(propertyInfo, "Property StudentID does not exist in Student class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(int), expectedType, "Property StudentID in Student class is not of type int");
    }
    [Test]
    public void Student_StudentName_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Student";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = StudentType.GetProperty("StudentName");
        Assert.IsNotNull(propertyInfo, "Property StudentName does not exist in Student class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property StudentName in Student class is not of type string");
    }
    [Test]
    public void Position_PositionID_PropertyExists_ReturnExpectedDataTypes_int()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("PositionID");
        Assert.IsNotNull(propertyInfo, "Property PositionID does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(int), expectedType, "Property PositionID in Position class is not of type int");
    }
    [Test]
    public void Position_PositionName_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("PositionName");
        Assert.IsNotNull(propertyInfo, "Property PositionName does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property PositionName in Position class is not of type string");
    }
    [Test]
    public void Position_Nominee1_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("Nominee1");
        Assert.IsNotNull(propertyInfo, "Property Nominee1 does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property Nominee1 in Position class is not of type string");
    }
    [Test]
    public void Position_Nominee2_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("Nominee2");
        Assert.IsNotNull(propertyInfo, "Property Nominee2 does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property Nominee2 in Position class is not of type string");
    }
    [Test]
    public void Position_Nominee3_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("Nominee3");
        Assert.IsNotNull(propertyInfo, "Property Nominee3 does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property Nominee3 in Position class is not of type string");
    }
    [Test]
    public void Position_Nominee4_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Position";
        Assembly assembly = Assembly.Load(assemblyName);
        Type PositionType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = PositionType.GetProperty("Nominee4");
        Assert.IsNotNull(propertyInfo, "Property Nominee4 does not exist in Position class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property Nominee4 in Position class is not of type string");
    }
    [Test]
    public void Vote_VoteSerialID_PropertyExists_ReturnExpectedDataTypes_int()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Vote";
        Assembly assembly = Assembly.Load(assemblyName);
        Type VoteType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = VoteType.GetProperty("VoteSerialID");
        Assert.IsNotNull(propertyInfo, "Property VoteSerialID does not exist in Student class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(int), expectedType, "Property VoteSerialID in Student class is not of type int");
    }
    [Test]
    public void Vote_NomineeName_PropertyExists_ReturnExpectedDataTypes_string()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Vote";
        Assembly assembly = Assembly.Load(assemblyName);
        Type VoteType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = VoteType.GetProperty("NomineeName");
        Assert.IsNotNull(propertyInfo, "Property NomineeName does not exist in Student class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(string), expectedType, "Property NomineeName in Student class is not of type string");
    }
    [Test]
    public void Vote_Date_Time_PropertyExists_ReturnExpectedDataTypes_Date_Time()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Models.Vote";
        Assembly assembly = Assembly.Load(assemblyName);
        Type VoteType = assembly.GetType(typeName);
        PropertyInfo propertyInfo = VoteType.GetProperty("Date_Time");
        Assert.IsNotNull(propertyInfo, "Property NomineeName does not exist in Student class");
        Type expectedType = propertyInfo.PropertyType;
        Assert.AreEqual(typeof(DateTime), expectedType, "Property Date_Time in Student class is not of type DateTime");
    }
    [Test]
    public void StudentController_Controllers_ClassExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentController";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentControllerType = assembly.GetType(typeName);
        Assert.IsNotNull(StudentControllerType);
    }
    [Test]
    public void StudentControllerType_Index_MethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentController";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentControllerType = assembly.GetType(typeName);
        MethodInfo methodInfo = StudentControllerType.GetMethod("Index");
        Assert.IsNotNull(methodInfo, "Method Index does not exist in StudentController class");
    }
    [Test]
    public void StudentControllerType_Create_MethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentController";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentControllerType = assembly.GetType(typeName);
        MethodInfo methodInfo = StudentControllerType.GetMethod("Index");
        Assert.IsNotNull(methodInfo, "Method Create does not exist in StudentController class");
    }


    [Test]
    public void StudentVoteController_Controllers_ClassExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentVoteController";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentVoteControllerType = assembly.GetType(typeName);
        Assert.IsNotNull(StudentVoteControllerType);
    }
   

    [Test]
    public void StudentVoteController_Index_MethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentVoteController";
        Assembly assembly = Assembly.Load(assemblyName);
        Type StudentVoteControllerType = assembly.GetType(typeName);
        MethodInfo methodInfo = StudentVoteControllerType.GetMethod("Index");
        Assert.IsNotNull(methodInfo, "Method Index does not exist in StudentVoteController class");
    }

    [Test]
    public void AppDbContext_ContainsDbSet_Vote()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(AppDbContext));
        Type contextType = assembly.GetExportedTypes().FirstOrDefault(t => typeof(DbContext).IsAssignableFrom(t));
        if (contextType == null)
        {
            Assert.Fail("No DbContext found in the assembly");
            return;
        }
        Type VoteType = assembly.GetExportedTypes().FirstOrDefault(t => t.Name == "Vote");
        if (VoteType == null)
        {
            Assert.Fail("No DbSet found in the DbContext");
            return;
        }
        var propertyInfo = contextType.GetProperty("voteTbl");
        if (propertyInfo == null)
        {
            Assert.Fail("voteTbl property not found in the DbContext");
            return;
        }
        else
        {
            Assert.AreEqual(typeof(DbSet<>).MakeGenericType(VoteType), propertyInfo.PropertyType);
        }
    }
    [Test]
    public void AppDbContext_ContainsDbSet_Student()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(AppDbContext));
        Type contextType = assembly.GetExportedTypes().FirstOrDefault(t => typeof(DbContext).IsAssignableFrom(t));
        if (contextType == null)
        {
            Assert.Fail("No DbContext found in the assembly");
            return;
        }
        Type StudentType = assembly.GetExportedTypes().FirstOrDefault(t => t.Name == "Student");
        if (StudentType == null)
        {
            Assert.Fail("No DbSet found in the DbContext");
            return;
        }
        var propertyInfo = contextType.GetProperty("studentTbl");
        if (propertyInfo == null)
        {
            Assert.Fail("studentTbl property not found in the DbContext");
            return;
        }
        else
        {
            Assert.AreEqual(typeof(DbSet<>).MakeGenericType(StudentType), propertyInfo.PropertyType);
        }
    }
    [Test]
    public void AppDbContext_ContainsDbSet_Position()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(AppDbContext));
        Type contextType = assembly.GetExportedTypes().FirstOrDefault(t => typeof(DbContext).IsAssignableFrom(t));
        if (contextType == null)
        {
            Assert.Fail("No DbContext found in the assembly");
            return;
        }
        Type PositionType = assembly.GetExportedTypes().FirstOrDefault(t => t.Name == "Position");
        if (PositionType == null)
        {
            Assert.Fail("No DbSet found in the DbContext");
            return;
        }
        var propertyInfo = contextType.GetProperty("positionTbl");
        if (propertyInfo == null)
        {
            Assert.Fail("positionTbl property not found in the DbContext");
            return;
        }
        else
        {
            Assert.AreEqual(typeof(DbSet<>).MakeGenericType(PositionType), propertyInfo.PropertyType);
        }
    }


    [Test]
    public void StudentVoteController_CreateGetMethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentVoteController";

        Assembly assembly = Assembly.Load(assemblyName);
        Type controllerType = assembly.GetType(typeName);

        MethodInfo createGetMethod = controllerType.GetMethod("Create", new Type[] { typeof(int) });

        Assert.IsNotNull(createGetMethod);
        Assert.IsTrue(typeof(IActionResult).IsAssignableFrom(createGetMethod.ReturnType));
    }


    [Test]
    public void StudentVoteController_CreatePostMethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentVoteController";
        string typeName1 = "Dotnet_M1_A2.Models.Vote";

        Assembly assembly = Assembly.Load(assemblyName);
        Type controllerType = assembly.GetType(typeName);
        Type modelType = assembly.GetType(typeName1);

        MethodInfo createPostMethod = controllerType.GetMethod("Create", new Type[] { modelType, typeof(int) });

        Assert.IsNotNull(createPostMethod);
        Assert.IsTrue(typeof(IActionResult).IsAssignableFrom(createPostMethod.ReturnType));
    }
    [Test]
    public void StudentController_CreatePostMethodExists()
    {
        string assemblyName = "Dotnet_M1_A2";
        string typeName = "Dotnet_M1_A2.Controllers.StudentController";
        string typeName1 = "Dotnet_M1_A2.Models.Student";

        Assembly assembly = Assembly.Load(assemblyName);
        Type controllerType = assembly.GetType(typeName);
        Type modelType = assembly.GetType(typeName1);

        MethodInfo createPostMethod = controllerType.GetMethod("Create", new Type[] { modelType });

        Assert.IsNotNull(createPostMethod);
        Assert.IsTrue(typeof(IActionResult).IsAssignableFrom(createPostMethod.ReturnType));
    }
    [Test]
public void AddVote_StudentVoteController_AddsTo_DBt()
{
    string assemblyName = "Dotnet_M1_A2";
    Assembly assembly = Assembly.Load(assemblyName);
    string controllerTypeName = "Dotnet_M1_A2.Controllers.StudentVoteController";
    string typeName = "Dotnet_M1_A2.Models.Vote";
    Type contextType = assembly.GetExportedTypes().FirstOrDefault(t => typeof(DbContext).IsAssignableFrom(t));


    Type controllerType = assembly.GetType(controllerTypeName);
    Type modelType = assembly.GetType(typeName);

    MethodInfo method = controllerType.GetMethod("Create", new[] { modelType, typeof(int) });

    if (method != null)
    {
        int positionId = 1;

        var voteData = new Dictionary<string, object>
        {
            { "NomineeName", "Test Nominee" },
        };

        var vote = Activator.CreateInstance(modelType);
        foreach (var kvp in voteData)
        {
            var propertyInfo = modelType.GetProperty(kvp.Key);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(vote, kvp.Value);
            }
        }

        var controller = Activator.CreateInstance(controllerType, _context);
        var result = method.Invoke(controller, new object[] { vote, positionId });

        Assert.IsNotNull(result);        
        
        // Retrieve the added data from the database
         var studentTblProperty = contextType.GetProperty("voteTbl");
        if (studentTblProperty != null)
        {
            var studentTbl = studentTblProperty.GetValue(_context) as IEnumerable<Student>;
            if (studentTbl != null)
            {
                var studentTblList = studentTbl.ToList();
               var studentname = studentTblList.FirstOrDefault(item => ((string)item.GetType().GetProperty("NomineeName").GetValue(item)) == "Test Nominee");
                Assert.IsNotNull(studentname);

            }
        }
    }
    else
    {
        Assert.Fail();
    }
}

[Test]
public void AddStudent_StudentController_AddsTo_DBt()
{
    string assemblyName = "Dotnet_M1_A2";
    Assembly assembly = Assembly.Load(assemblyName);
    string controllerTypeName = "Dotnet_M1_A2.Controllers.StudentController";
    string typeName = "Dotnet_M1_A2.Models.Student";
    Type contextType = assembly.GetExportedTypes().FirstOrDefault(t => typeof(DbContext).IsAssignableFrom(t));

    Type controllerType = assembly.GetType(controllerTypeName);
    Type modelType = assembly.GetType(typeName);

    MethodInfo method = controllerType.GetMethod("Create", new[] { modelType });

    if (method != null)
    {
        var studentData = new Dictionary<string, object>
        {
            { "StudentName", "Test Student" },
        };

        var student = Activator.CreateInstance(modelType);
        foreach (var kvp in studentData)
        {
            var propertyInfo = modelType.GetProperty(kvp.Key);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(student, kvp.Value);
            }
        }

        var controller = Activator.CreateInstance(controllerType, _context);
        var result = method.Invoke(controller, new object[] { student });

        Assert.IsNotNull(result);

        // Retrieve the added data from the database
        var studentTblProperty = contextType.GetProperty("studentTbl");
        if (studentTblProperty != null)
        {
            var studentTbl = studentTblProperty.GetValue(_context) as IEnumerable<Student>;
            if (studentTbl != null)
            {
                var studentTblList = studentTbl.ToList();
               var studentname = studentTblList.FirstOrDefault(item => ((string)item.GetType().GetProperty("StudentName").GetValue(item)) == "Test Student");
                Assert.IsNotNull(studentname);

            }
        }
    }
    else
    {
        Assert.Fail();
    }
} 

[Test]
public void Index_StudentController_Returns_Correct_View_And_Model()
{
    string assemblyName = "Dotnet_M1_A2";
    Assembly assembly = Assembly.Load(assemblyName);
    string modelType = "Dotnet_M1_A2.Models.Student";
    string controllerTypeName = "Dotnet_M1_A2.Controllers.StudentController";
    Type controllerType = assembly.GetType(controllerTypeName);
    Type controllerType2 = assembly.GetType(modelType);

    var studentData = new Dictionary<string, object>
    {
        { "StudentID", 1 },
        { "StudentName", "Test Student new" }
    };
    var Student = Activator.CreateInstance(controllerType2);
    foreach (var kvp in studentData)
    {
        var propertyInfo = controllerType2.GetProperty(kvp.Key);
        if (propertyInfo != null)
        {
            propertyInfo.SetValue(Student, kvp.Value);
        }
    }
    _context.studentTbl.Add((Student)Student);
    _context.SaveChanges();

    MethodInfo method = controllerType.GetMethod("Index");

    if (method != null)
    {
        var controller = Activator.CreateInstance(controllerType, _context);
        var result = method.Invoke(controller, null) as ViewResult;
        var model = result.Model as List<Student>;

        Assert.IsNotNull(result);
        Assert.AreEqual(1, model.Count);
        Assert.AreEqual(1, model.FirstOrDefault().GetType().GetProperty("StudentID").GetValue(model.FirstOrDefault()));

        PropertyInfo studentTblProperty = _context.GetType().GetProperty("studentTbl");
        if (studentTblProperty != null)
        {
            var studentTbl = studentTblProperty.GetValue(_context) as IEnumerable<Student>;
            if (studentTbl != null)
            {
                var studentTblList = studentTbl.ToList();
                Assert.IsTrue(studentTblList.Count > 0);
                var firststudent = studentTblList.FirstOrDefault(item => ((int)item.GetType().GetProperty("StudentID").GetValue(item)) == 1);
                Assert.IsNotNull(firststudent);
               // Assert.AreEqual("Test Student new", firststudent.StudentName);
               var studentname = studentTblList.FirstOrDefault(item => ((string)item.GetType().GetProperty("StudentName").GetValue(item)) == "Test Student new");
              //  Assert.AreEqual("Test Student new", (string)modelType.FirstOrDefault().GetType().GetProperty("StudentName").GetValue(modelType.FirstOrDefault()));
                Assert.IsNotNull(studentname);

            }
        }
    }
    else
    {
        Assert.Fail();
    }
}
}




