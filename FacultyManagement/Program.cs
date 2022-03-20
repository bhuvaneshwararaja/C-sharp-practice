using System;
using System.Collections;


namespace FacultyManagementSystem{
    class Faculty{
        public string name{get;set;}
        public int age{get;set;}
        public double salary{get;set;}
        public string designation{get;set;}
        public bool isPermanent{get;set;}

        public Faculty(string name,int age,double salary,string designation,bool isPermanent){
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.designation = designation;
            this.isPermanent  = isPermanent;
        }
        public Faculty(){
            name = "";
            age=0;
            salary=0;
            designation="";
            isPermanent=false;

        }
    }

    class FacultyManagement{
        public List<Faculty> faculty = new List<Faculty>();

        public List<Faculty> ListFaculty(string designation){
                List<Faculty> filteredFaculty = new List<Faculty>();
                foreach(Faculty f in faculty ){
                        if((designation.ToLower() == f.designation.ToLower()) && (f.age > 25)){
                            filteredFaculty.Add(f);
                        }
                }
                return filteredFaculty ;
        }  

       public string MaxSalary(bool isPermanent)
        {   
            //string Maxname ="";
             double max = 0.00;
             Faculty b = new Faculty();
            List<Faculty> Salary = new List<Faculty>();
            foreach(Faculty f in faculty){
                if(f.isPermanent == true && f.salary > max){
                    max = f.salary;
                    b = f;
                }
                
            }
           
            return  b.name;
           
                
            }   
        }
    class MainProgram{
        static void Main(string[] args){
            FacultyManagement fac = new FacultyManagement();
                Console.WriteLine("Enter the number of Faculty to add");
                int n = int.Parse(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.WriteLine("Enter the name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the age");

                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the salary");
                    double salary= double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the designation");

                    string designation = Console.ReadLine();
                    Console.WriteLine("Enter the ispermanent");

                    bool isPermanent = bool.Parse(Console.ReadLine());

                    fac.faculty.Add(new Faculty(name,age,salary,designation,isPermanent));
                }

                Console.WriteLine("Enter your choice 1.filteredFaculty 2.MAxSalary");
                int ch = int.Parse(Console.ReadLine());
                switch(ch){
                    case 1:{
                        Console.WriteLine("Enter the designation to filter");
                        string temp = Console.ReadLine();
                        List<Faculty> result = fac.ListFaculty(temp);
                        foreach(Faculty f in result){
                            Console.WriteLine($"{f.name} {f.age} {f.designation} {f.salary} {f.isPermanent}");
                        }

                        break;
                    }
                    case 2:{
                       Console.WriteLine("Enter ispermanent");
                       bool val = bool.Parse(Console.ReadLine());
                       string Name = fac.MaxSalary(val);
                       Console.WriteLine(Name);
                       break;
                    }
                    default:{
                        Console.WriteLine("Invalid Selection");
                        break;
                    }
        }
    }
    }}