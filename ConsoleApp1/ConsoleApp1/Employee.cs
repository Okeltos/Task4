using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private string _fio;
        private int _department;
        private double _salary;
        static int coount;
        private int _id = 0;
        public Employee (string fio, int departmetn, double salary)
        { 
            _fio = fio;
            _department = departmetn;
            _salary = salary;
        }
        public int Id()
        {
            _id++;
            coount =_id;
            return coount;
        }
        public int IdUpdate()
        {
            _id = 0;
            coount = _id;
            return coount;
        }
        public string Fio
        {
            get
            {
                return _fio;
            }
            set
            { 
                _fio=value;
            }
        }
        public int Department
        {
            get 
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public Employee()
        { }
            
    }
}
