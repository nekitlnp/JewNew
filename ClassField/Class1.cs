using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassField
{
    /// <summary>
    /// вывод заказа
    /// </summary>
    public class OrderTable
    {
        /// <summary>
        /// Тип изделия
        /// </summary>
        public string JewType { get; set; }
        /// <summary>
        /// дата сдачи
        /// </summary>
        public string DateOfDel { get; set; }
        /// <summary>
        /// когда забирать
        /// </summary>
        public DateTime DateOfReady { get; set; }
        /// <summary>
        /// Описание изделия
        /// </summary>
        public string Description { get; set; }
    }
    /// <summary>
    /// заказчик
    /// </summary>
    public class BlockJewelry
    {
        /// <summary>
        /// Контактные данные
        /// </summary>
        public List<string> ContactDetails { get; set; }
        /// <summary>
        /// имя заказчика
        /// </summary>
        public string NameCostumer { get; set; }
    }

    public class Jewelry
    {
        /// <summary>
        /// Тип изделия
        /// </summary>
        public string JewType;
        /// <summary>
        /// дата сдачи
        /// </summary>
        public string DateOfDel { get; set; }
        /// <summary>
        /// тип металла
        /// </summary>
        public string MetType { get; set; }
        /// <summary>
        /// Описание изделия
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Фотография до ремонта
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// когда забирать
        /// </summary>
        public string DateOfReady { get; set; }
    }
    
    /// <summary>
    /// Тип изделия
    /// </summary>
    public enum JewType
    {
        /// <summary>
        /// кольцо
        /// </summary>
        Ring,
        /// <summary>
        /// браслет
        /// </summary>
        Bracelet,
        /// <summary>
        /// цепь/цепочка
        /// </summary>
        Chain,
        /// <summary>
        /// подвеска
        /// </summary>
        Suspension,
        /// <summary>
        /// серьги
        /// </summary>
        Earrings,
    }

    /// <summary>
    /// Тип металла
    /// </summary>
    public enum MetType
    {
        /// <summary>
        /// Золото
        /// </summary>
        Gold,
        /// <summary>
        /// Серебро
        /// </summary>
        Silver,
        /// <summary>
        /// Бижутерия
        /// </summary>
        Bijouterie,
        /// <summary>
        /// платина
        /// </summary>
        Platinum,
    }
}