using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TripEntity
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }

        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha Final")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? EndDate { get; set; }

        public DateTime? EndDateLocal => EndDate?.ToLocalTime();

        [Display(Name = "Origen")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener {1} caracteres.")]
        public string Source { get; set; }

        [Display(Name = "Destino")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener {1} caracteres.")]
        public string Target { get; set; }

        [Display(Name = "Calificación")]
        public float Qualification { get; set; }

        [Display(Name = "Origen lactitud")]
        public double SourceLatitude { get; set; }

        [Display(Name = "Origen longitud")]
        public double SourceLongitude { get; set; }

        [Display(Name = "Destino lactitud")]
        public double TargetLatitude { get; set; }

        [Display(Name = "Destino longitud")]
        public double TargetLongitude { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public TaxiEntity Taxi { get; set; }

        public ICollection<TripDetailEntity> TripDetails { get; set; }

        public UserEntity User { get; set; }
    }
}
