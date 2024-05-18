namespace LearnnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>()
            //{
            //        new Employee() {Id =1, Name="Test1", Email="test1@gmail.com "},
            //        new Employee() {Id =2, Name="Test2", Email="test2@gmail.com "},
            //        new Employee() {Id =3, Name="Test3", Email="test3@gmail.com "},
            //};

            //var basicQuery = (from emp in employees
            //                  select emp).ToList();

            //Console.WriteLine(basicQuery);


            //foreach (var item in basicQuery)
            //{
            //    Console.WriteLine($"Id: {item.Id} Name: {item.Name} Email: {item.Email}");
            //}

            //Basic query based on propery
            //var basicPropertyQuery = (from emp in employees
            //                          select emp.Id).ToList();
            //foreach (var item in basicPropertyQuery)
            //{
            //    Console.WriteLine($"basicPropertyQuery: {item}");
            //}

            //Basic query based on propery
            //var basicPropertyQuery2 = (from emp in employees
            //                          select new Employee() 
            //                          { Id = emp.Id,
            //                            Email = emp.Email,
            //                          })
            //                          .ToList();

            //foreach (var item in basicPropertyQuery2)
            //{ 
            //    Console.WriteLine($"basicPropertyQueryIdAndEmail: {item.Id} : {item.Email} ");
            //}
            //var selectQuery  = (from emp in employees
            //                             select new Student() 
            //                             {
            //                               StudentId = emp.Id,
            //                               StEmail = emp.Email,
            //                               FullName = emp.Name,
            //                             })
            //                             .ToList();

            //   foreach (var item in selectQuery)
            //   {
            //       Console.WriteLine($"studentQuery: {item.StudentId} : {item.StEmail} : {item.FullName} ");
            //   }


            //var selectStudent = employees.Select(emp => new Student() 
            //                   {  
            //                       StudentId = emp.Id,
            //                       StEmail = emp.Email,
            //                       FullName = emp.Name,
            //                   }).ToList();

            //foreach (var item in selectStudent)
            //{
            //    Console.WriteLine($"selectStudent: {item.StudentId} : {item.StEmail} : {item.FullName} ");
            //}



            //var selectCustomType = employees.Select(emp => new
            //{
            //    CustomId = emp.Id,
            //    CustomEmail = emp.Email,
            //    CustomFullName = emp.Name,
            //}).ToList();

            //foreach (var item in selectCustomType)
            //{
            //    Console.WriteLine($"selectCustomType: {item.CustomId} : {item.CustomEmail} : {item.CustomFullName} ");
            //}


            //var selectCustomTypeIndex = employees.Select((emp, index) => new
            //{
            //    CustomId = emp.Id,
            //    CustomEmail = emp.Email,
            //    CustomFullName = emp.Name,
            //    CustomIndex = index 
            //}).ToList();

            //foreach (var item in selectCustomTypeIndex)
            //{
            //    Console.WriteLine($"selectCustomType: {item.CustomId} : {item.CustomEmail} : {item.CustomFullName} Index:{item.CustomIndex}");
            //}

            //var basicMethod = employees.ToList();

            //var basicPropertyMethod = employees.Select(emp => emp.Name ).ToList();

            //foreach (var item in basicPropertyMethod)
            //{
            //    Console.WriteLine($"basicPropertyMethod: {item}");
            //}



            //Using SelectMany

            //List<string> stringList = new List<string>() { "Testname ", "Hello" };

            //var methodResult  = stringList.SelectMany(x => x).ToList();

            //foreach (var item in methodResult) 
            //{
            //    Console.WriteLine($"methodResult: {item}");
            //}

            //var queryResult = (from str in stringList
            //                  from character in str
            //                  select character).ToList();

            //foreach (var item in queryResult)
            //{
            //    Console.WriteLine($"queryResult: {item}");
            //}


            //List<Employee> employees = new List<Employee>()
            //{
            //        new Employee() {Id =1, Name="Test1", Email="test1@gmail.com"},
            //        new Employee() {Id =2, Name="Test2", Email="test2@gmail.com"},
            //        new Employee() {Id =3, Name="Test3", Email="test3@gmail.com"},
            //};

            //var res = employees.SelectMany(x=>x.Email).ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"res: {item}");
            //}

            // List<Employee> dataSources = new List<Employee>()
            // {
            //         new Employee() {Id =1, Name="Test1", Email="test1@gmail.com",  Programming = new List<string>(){ "C#","PHP", "JAVA" } },
            //         new Employee() {Id =2, Name="Test2", Email="test2@gmail.com",  Programming = new List<string>(){ "LINQ", "C#", "MVC" } },
            //         new Employee() {Id =3, Name="Test3", Email="test3@gmail.com",  Programming = new List<string>(){ "LINQ", "VB", "SQL" } },
            // };

            // var methodSyntax = dataSources.SelectMany(x => x.Programming).ToList();
            // var querySyntax = (from obj in dataSources
            //                   from prog in obj.Programming
            //                   select prog).ToList();

            // foreach (var item in methodSyntax)
            // {
            //     Console.WriteLine($"methodSyntax: {item}");
            // }
            //foreach (var item in querySyntax)
            // {
            //     Console.WriteLine($"querySyntax: {item}");
            // }

            //List<Employee> dataSources = new List<Employee>()
            // {
            //        new Employee()
            //         {
            //             Id =1, Name="Test1", Email="test1@gmail.com",  Programming =
            //             new List<Techs>() {
            //                 new Techs() { Technology ="C#" },
            //                 new Techs() { Technology ="PHP" },
            //                 new Techs() { Technology ="JAVA" }
            //             }
            //         },
            //        new Employee()
            //          {
            //              Id =2, Name="Test2", Email="test2@gmail.com",   Programming =
            //              new List<Techs>(){
            //                  new Techs() {Technology ="Javascript"},
            //                  new Techs() {Technology ="Node js"},
            //                  new Techs() {Technology ="Angular"}
            //              }
            //          },
            //        new Employee()
            //         {
            //             Id =3, Name="Test3", Email="test3@gmail.com",  Programming =
            //              new List<Techs>(){
            //                  new Techs() {Technology ="React"},
            //                  new Techs() {Technology ="Node js"},
            //                  new Techs() {Technology ="MongoDB"}
            //              },
            //         },
            //        new Employee()
            //         {
            //             Id =4, Name="Test4", Email="test4@gmail.com",  Programming =
            //              new List<Techs>(),
            //         },
            //        new Employee()
            //         {
            //             Id =5, Name="Test5", Email="test5@gmail.com",  Programming =
            //              new List<Techs>(),
            //         },
            // };

            //var methodSyntax = dataSources.SelectMany(x => x.Programming.Select(e=>e.Technology)).ToList();
            //var querySyntax = (from obj in dataSources
            //                   from prog in obj.Programming
            //                   select prog).ToList();



            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"methodSyntax: {item}");
            //}
            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine($"querySyntax: {item.Technology}");
            //}


            //Fitering operation
            //Where oprator
            //var  dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var querySyntax = (from num in dataSource
            //                  where num > 5
            //                   select num).ToList();
            //var methodSyntax = dataSource.Where(x => x > 5).ToList();   
            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine($"querySyntax: {item}");
            //}
            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"methodSyntax: {item}");
            //}

            //OfType operator

            //var dataSource = new List<object> { "Adam", "Henry", "Jhon", "gf", 1, 2, 3, 4 };
            //var dataSource2 = dataSource.OfType<string>().Where(x => x.Length>3).ToList();
            //var dataSource3 = dataSource.OfType<int>().ToList();

            //var dataSource2Query = (from obj in dataSource
            //                       where obj is string
            //                       select obj).ToList();

            //foreach (var item in dataSource)
            //{
            //    Console.WriteLine($"dataSource: {item}");
            //}
            //foreach (var item in dataSource2)
            //{
            //    Console.WriteLine($"dataSource2: {item}");
            //}
            //foreach (var item in dataSource3)
            //{
            //    Console.WriteLine($"dataSource3: {item}");
            //}

            //foreach (var item in dataSource2Query)
            //{
            //    Console.WriteLine($"dataSource2Query: {item}");
            //}


            //Sorting operator
            //OrderBy

            //var dataSourceInt = new List<int>() { 34, 42, 3, 6, 7, 5, 100, 67, 1, 56 };
            //var dataSourceSring = new List<string>() { "sagor", "akash", "akkas", "sujon", "sathi" };

            //var methodSyntax1 = dataSourceInt.OrderBy(x => x);
            //var qerySyntax = (from item in dataSourceInt
            //                  where item > 10
            //                  orderby item
            //                  select item).ToList();

            //foreach (var item in qerySyntax)
            //{
            //    Console.WriteLine($"qerySyntax: {item}");
            //}
            //var methodSyntax = dataSourceSring.OrderBy(x => x);

            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"methodSyntax: {item}");
            //}


            //List<Employee> employees = new List<Employee>()
            //{
            //        new Employee() {Id =1, Name="Varim", Email="test1@gmail.com"},
            //        new Employee() {Id =3, Name="Rahim", Email="test2@gmail.com"},
            //        new Employee() {Id =2, Name="Rahuma", Email="test3@gmail.com"},
            //};
            //var methodSyntax = employees.OrderBy(emp => emp.Name).ToList();
            //var querySyntax = (from emp in employees
            //                   orderby emp.Name
            //                   select emp).ToList();

            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"querySyntax: {item.Id} : {item.Name}");
            //}


            //OrderByDescending
            //var dataSourceInt = new List<int>() { 34, 42, 3, 6, 7, 5, 100, 67, 1, 56 };
            //var methodSyntax = dataSourceInt.OrderByDescending(num => num).ToList();
            //var querySyntax = (from num in dataSourceInt
            //                   where num < 10
            //                   orderby num descending
            //                   select num).ToList();
            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine($"querySyntax: {item} : {item}");
            //}

            //var methodSyntax = employees.OrderByDescending(emp => emp.Id ).ToList();
            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine($"querySyntax: {item.Id} : {item.Name}");
            //}


            //Thenby

            //List<Employee> employees = new List<Employee>()
            //{
            //        new Employee() {
            //            Id =1, 
            //            Name="Varim", 
            //            Email="test1@gmail.com",
            //            Firstname= "Rahim",
            //            Lastname= "Kuddus"
            //        },
            //        new Employee() {
            //            Id =3, 
            //            Name="Rahim", 
            //            Email="test2@gmail.com",
            //            Firstname= "Rahim",
            //            Lastname= "Aria"
            //        },
            //        new Employee() {
            //            Id =6, 
            //            Name="Rahuma", 
            //            Email="test3@gmail.com",
            //            Firstname= "Karim",
            //            Lastname= "Bakker"
            //        },
            //        new Employee() {
            //            Id =4,
            //            Name="Rahuma",
            //            Email="test3@gmail.com",
            //            Firstname= "Karim",
            //            Lastname= "Juel"
            //        },
            //       new Employee() {
            //            Id =5,
            //            Name="Rahuma",
            //            Email="test3@gmail.com",
            //            Firstname= "Test name",
            //            Lastname= "Khalek"
            //        },
            //};

            //var ms = employees.OrderBy(emp => emp.Firstname).ThenBy(emp => emp.Id).ToList();

            //var qs = (from emp in employees
            //          orderby emp.Firstname, emp.Id
            //          select emp).ToList();

            //foreach (var item in qs)
            //{
            //    Console.WriteLine($"qs----> Id: {item.Id}, Firstname: {item.Firstname}, Lastname:{item.Lastname}");
            //}


            //Reverse
            //List<string> strList = new List<string>() { "Adan", "Jim", "Kim", "Jiks"};

            //foreach (var item in strList)
            //{
            //    Console.WriteLine($"Before----> {item}");
            //}

            //strList.Reverse();

            //foreach (var item in strList)
            //{
            //    Console.WriteLine($"After----> {item}");
            //}


            //I want to reserved method but no efect on main list.

            //List<string> strList = new List<string>() { "Adan", "Jim", "Kim", "Jiks" };

            //foreach (var item in strList)
            //{
            //    Console.WriteLine($"Before----> {item}");
            //}

            ////strList.Reverse();

            //var reserved = strList.AsEnumerable().Reverse();

            //foreach (var item in reserved)
            //{
            //    Console.WriteLine($"After----> {item}");
            //}

            //All
            Student[] students =
            {
                new Student()
                {
                    StudentId = 1,
                    FullName = "Kim",
                    Marks = 90,
                    Subject = new List<Subject>(){
                        new Subject(){
                          SubjectName = "Math",
                          SubjectMarks = 73
                        },
                        new Subject(){
                        SubjectName = "English",
                        SubjectMarks = 80,
                        },
                        new Subject(){
                          SubjectName = "Bangla",
                          SubjectMarks = 85,
                        },
                        new Subject(){
                          SubjectName = "Science",
                          SubjectMarks = 78,
                        }
                    }
                },
                new Student()
                {
                    StudentId = 2,
                    FullName = "Lee",
                    Marks = 79,
                    Subject = new List<Subject>(){
                        new Subject(){
                          SubjectName = "Math",
                          SubjectMarks = 86
                        },
                        new Subject(){
                        SubjectName = "English",
                        SubjectMarks = 88,
                        },
                         new Subject(){
                          SubjectName = "Bangla",
                          SubjectMarks = 90,
                        },
                        new Subject(){
                          SubjectName = "Science",
                          SubjectMarks = 82,
                        }
                    }
                },
                new Student()
                {
                    StudentId = 3,
                    FullName = "Jhon",
                    Marks = 88,
                    Subject = new List<Subject>(){
                        new Subject(){
                          SubjectName = "Math",
                          SubjectMarks = 90
                        },
                        new Subject(){
                        SubjectName = "English",
                        SubjectMarks = 95,
                        },
                         new Subject(){
                          SubjectName = "Bangla",
                          SubjectMarks = 84,
                        },
                        new Subject(){
                          SubjectName = "Science",
                          SubjectMarks = 71,
                        }
                    }
                }
            };

            //var ms = students.Where(std => std.Subject.All(x => x.SubjectMarks > 70)).ToList();

            //var qs = (from std in students
            //          where std.Subject.All(x => x.SubjectMarks > 80)
            //          select std).ToList();
            //Console.WriteLine(qs.Count);

            //Any

            var ms = students.Any(x => x.Marks > 97);
            Console.WriteLine(ms);

            Console.ReadLine();
        }

    }
}

