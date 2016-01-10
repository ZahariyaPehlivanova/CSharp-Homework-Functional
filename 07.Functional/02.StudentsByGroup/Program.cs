using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
               {
               new Student("Gosho","Petkov",20,2255332,088436619,"Gosho@abv.bg",new List<int>{3,5,6,2,4},2),
               new Student("Mariq","Ivanova",18,3597415,0896357417,"Mariq@abv.bg",new List<int>{2,6,6,5,6},11),
               new Student("Ana","Dimitrova",19,8534697,0885369428,"Ana@abv.bg",new List<int>{6,3,5,4,2},9),
               new Student("Ivan","Dimitrov",23,6324875,0889354715,"Ivan@abv.bg",new List<int>{3,6,5,4,2},1),
               new Student("Geri","Georgieva",21,5369554,0892354715,"Geri@abv.bg",new List<int>{3,2,5,6,4},6),
               new Student("Pesho","Peshov",20,8546541,0896325472,"Pesho@abv.bg",new List<int>{5,6,5,4,2},5)
               };
        }
    }
}
