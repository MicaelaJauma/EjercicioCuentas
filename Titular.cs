using System;
 public class Titular
 {
     public string DNI { get; set;}
     public string Nombre { get; set;}
     public string Apellido {get; set;}
     public string Mail { get; set;}
     public string Teléfono { get; set; }
     public DateTime FechaDeNacimiento { get; set; }
     public string NombreCompleto()
     {
         return string.Format ( "{0} {1}", this.Nombre, this.Apellido);
     }
 }

