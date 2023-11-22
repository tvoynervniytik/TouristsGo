//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouristsGo.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tours()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdTypetour { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> IdNutrition { get; set; }
        public Nullable<int> IdCountry { get; set; }
        public Nullable<int> IdCity { get; set; }
        public Nullable<int> IdHotel { get; set; }
        public Nullable<bool> Actuality { get; set; }
        public byte[] Foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Nutrition Nutrition { get; set; }
        public virtual TypeTour TypeTour { get; set; }
    }
}