using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class stu
    {
        //fields
        private string _name;
        private string _famil;
        private int _age;
        private int _score;
        //consreuctors
        public stu()
        {
            _name = "";
            _famil = "";
            _age = 0;
            _score = 0;
        }
        public stu(string b, string c, int s, int m)
        {
            _name = b;
            _famil = c;
            _age = s;
            _score = m;
        }
        //properties
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string famil
        {
            get { return _famil; }
            set { _famil = value; }
        }
        public int age
        {
            get { return _age; }
            set
            {
                if (value > 15)
                    _age = value;
            }
        }
        public int score
        {
            get { return _score; }
            set { _score = value; }
        }
        //methods
        public void drive()
        {
            Console.WriteLine("the car is driving!");
        }
        public void stop()
        {
            Console.WriteLine("the car is stoped!");
        }
        public string showstude()
        {

            string result = "name:" + _name + "famil" + _famil + "age" + _age + "score:" + _score;
            return result;
        }

    }
}
