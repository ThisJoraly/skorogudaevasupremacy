//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zhopaSArfoi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reader
    {
        public int ID_Reader { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public int Book_ID { get; set; }
    
        public virtual Book Book { get; set; }
    }
}