using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;

namespace WpfApp3
{
    public class Student
    {
        public Student() { }
        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    [Serializable]
    public class StringDataSource
    {
        public ObservableCollection<Student> data = new ObservableCollection<Student>();
    }
}
