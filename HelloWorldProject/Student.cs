using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Student {
		string FirstName;
		string LastName;
		int StudentId;
		double GPA;
		int SAT;
		int ACT;
		bool IsFemale;

		public string GetFirstName() {
			return FirstName;
		}
		public void SetFirstName(string pFirstName) {
			FirstName = pFirstName;
		}

		public string GetLastName() {
			return LastName;
		}
		public void SetLastName(string pLastName) {
			LastName = pLastName;
		}

		public int GetStudentId() {
			return StudentId;
		}

		public void SetStudentId(int pStudentId) {
			StudentId = pStudentId;
		}

		public double GetGPA() {
			return GPA;
		}

		public void SetGPA(double pGPA) {
			GPA = pGPA;
		}
	}
}
