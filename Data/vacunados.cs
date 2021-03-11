using System;

namespace __tarea7.Data
{
    public class vacunados
    {
        public long Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long telefono { get; set; }
        public string fechaNacimiento { get; set; }
        public string tipoVacuna { get; set; }
        public string provincia { get; set; }

        public string fecahDosis1 { get; set; }
        public string fecahDosis2 { get; set; }

        public String SignoZodiacal(DateTime fecha)
        {
            int mes = fecha.Month;
            int dia = fecha.Day;

            switch (mes)
            {
                case 1:
                    return (dia < 21) ? "Capricornio" : "Acuario";
                case 2:
                    return (dia < 20) ? "Acuario" : "Piscis";
                case 3:
                    return (dia < 21) ? "Piscis" : "Aries";
                case 4:
                    return (dia < 20) ? "Aries" : "Tauro";
                case 5:
                    return (dia < 21) ? "Tauro" : "Géminis";
                case 6:
                    return (dia < 20) ? "Géminis" : "Cancer";
                case 7:
                    return (dia < 21) ? "Cancer" : "Leo";
                case 8:
                    return (dia < 20) ? "Leo" : "Virgo";
                case 9:
                    return (dia < 21) ? "Virgo" : "Libra";
                case 10:
                    return (dia < 22) ? "Libra" : "Escorpio";
                case 11:
                    return (dia < 23) ? "Escorpio" : "Sagitario";
                case 12:
                    return (dia < 19) ? "Sagitario" : "Capricornio";
            }

            throw new Exception("Error");
        }
    }
}
