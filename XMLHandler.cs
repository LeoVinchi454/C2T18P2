using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P2
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие XML");
        }
        public override void Create()
        {
            Console.WriteLine("Создание XML");
        }
        public override void Change()
        {
            Console.WriteLine("Изменение XML");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение XML");
        }
    }
}
