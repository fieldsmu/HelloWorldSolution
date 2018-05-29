using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		static void Main(string[] args) {
			string[] arr = {"Marcus", "Dan", "Mike", "Jonathan", "Larry", "Anna", "Foster", "William", "Mitch", "Jermaine", "Greg"};
			for (var i = 0; i < arr.Length; i++) {
				Console.WriteLine(arr[i]);
			}
			int numoftimes = 0;
			while (numoftimes < 1000) {
				int randomOne = 1;
				int randomTwo = 2;
				int randomThree = 3;
				var rnd = new Random();
				while (randomOne != randomTwo || randomOne != randomThree) {
					randomOne = rnd.Next(0, 9);
					randomTwo = rnd.Next(0, 9);
					randomThree = rnd.Next(0, 9);
					int[] randomarr = { randomOne, randomTwo, randomThree };
					for (var i = 0; i < randomarr.Length; i++) {
						Console.Write(randomarr[i]);
					}
					numoftimes++;
					Console.WriteLine();
				}
			}
			Console.WriteLine("Number of Attempts " + numoftimes);

			///////////////////////////////////////////////
			// THIS IS STUDENT DATA
			///////////////////////////////////////////////

			Student student = new Student();

			student.SetFirstName("Marcus");
			string fName;
			fName = student.GetFirstName();
		
			student.SetLastName("Fields");
			string lName;
			lName = student.GetLastName();

			Console.WriteLine("Student Name: " + fName + " " + lName);

			student.SetStudentId(401083);
			int sId;
			sId = student.GetStudentId();
			Console.WriteLine("Student ID: " + sId);

			student.SetGPA(4.00);
			double GPA;
			GPA = student.GetGPA();
			Console.WriteLine("GPA: " + GPA);
		}
	}
}
