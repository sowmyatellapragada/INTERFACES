using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : IStudent
    {
        private string stname;
        private int stmoney;
        private int styearsLearn;
        private int stratings;

        public Student() { }
        public void Stud(string name, int money, int yearsLearn, int ratings)
        {
            stname = name;
           stmoney = money;
           styearsLearn = yearsLearn;
            stratings = ratings;
        }
        public void Name(string name)
        {
           stname = name;
        }

        #region Interface
        public string GetName { get { return _name; } }
        public int GetPaymentStudy { get { return _money; } }
        public int GetYearStudy { get { return _yearsLearn; } }
        public int GetRating { get { return _ratings; } }
        #endregion
    }
}
