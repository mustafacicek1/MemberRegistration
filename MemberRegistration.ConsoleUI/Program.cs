using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member {
            FirstName="Mustafa",
            LastName="Çiçek",
            DateOfBirth=new DateTime(1998,1,10),
            Email="EMAILADRESS",
            TcNo="TCNO"
            });
            Console.WriteLine("Added.");
            Console.ReadLine();
        }
    }
}
