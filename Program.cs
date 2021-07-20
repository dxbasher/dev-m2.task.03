using System;
using System.Linq;
using dev_m2.task._03.Models;

namespace dev_m2.task._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mi primer acceso a datos.");

            using(var conexion = new ElcoBitContext()  ){

                    EntidaFederativa nuevaEntidad = new EntidaFederativa();
                    nuevaEntidad.EntidadId = 4;
                    nuevaEntidad.Nombre = "Campeche";
                    nuevaEntidad.NombreAbreviado = "Camp.";
                    
                    nuevaEntidad.PoblacionFemenina = 728924;
                    nuevaEntidad.PoblacionMasculina = 696683;
                    nuevaEntidad.PoblacionTotal = nuevaEntidad.PoblacionFemenina + nuevaEntidad.PoblacionMasculina;

                conexion.EntidaFederativas.Add(nuevaEntidad);
                conexion.SaveChanges();

               var listaResultados =  conexion.EntidaFederativas.Where(entidad => entidad.EntidadId > 1).ToList();

                Console.WriteLine("Recorre un arreglo con for");
                for(int i = 0; i < listaResultados.Count; i++){
                    var resultado = listaResultados[i];
                    Console.WriteLine($"EntidadID = {resultado.EntidadId}  Nombre: { resultado.Nombre }");
                }

                Console.WriteLine("Recorre un lista con foreach");
                foreach(var resultado in listaResultados){
                    Console.WriteLine($"EntidadID = {resultado.EntidadId}  Nombre: { resultado.Nombre }");
                } 


            }

             

        }
    }
}
