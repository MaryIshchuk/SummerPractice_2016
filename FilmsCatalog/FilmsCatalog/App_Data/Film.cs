//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmsCatalog.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public int Genre { get; set; }
        public int Decennary { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public string Actors { get; set; }
        public double Rating { get; set; }
        public string Trailer { get; set; }
    
        public virtual Decennary Decennary1 { get; set; }
        public virtual Genre Genre1 { get; set; }
    }
}
