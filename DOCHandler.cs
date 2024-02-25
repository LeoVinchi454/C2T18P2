using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Создание DOC");
        }
        public override void Change()
        {
            Console.WriteLine("Изменение DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение DOC");
        }
    }
}
