using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P2
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Создание TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Изменение TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение TXT");
        }
    }
}
