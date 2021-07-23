using System;
using System.Linq;
using System.IO;
using dev_m2.task._03.Models;

namespace dev_m2.task._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mi primer acceso a datos.");
            string path = System.IO.Path.GetFullPath("Archivos/EntidadFederativa.csv");
/*
           var datos = File.ReadAllLines(path);
            foreach(var ln in datos){
                if(ln.Length>1){
                    // Console.WriteLine($"{contador ++}   ---   {linea}");
                    var dato = ln.Split(',');
                    var id = dato[0].Replace('"',' ');
                    var nombre  = dato[1];
                    if(nombre.Length > 1){
                        var nombreModificado = nombre.Substring(1,nombre.Length-2);
                            Console.WriteLine($"{nombreModificado}");  
                            nombre = nombreModificado;  
                    }


                    var abrev  = dato[2].Replace('"',' ');
                    var poblacionTotal = dato[3].Replace('"',' ');
                    var poblacionMasculina = dato[5].Replace('"',' ');
                    var poblacionFemenina = dato[6].Replace('"',' ');
                    
                   
                    int entidadID = 0;
                    
                    if( int.TryParse(id,out entidadID)) {
                        using(var conexion = new ElcoBitContext()  ){

                            EntidaFederativa nuevaEntidad = new EntidaFederativa();
                            nuevaEntidad.EntidadId = entidadID;
                            nuevaEntidad.Nombre = nombre;
                            nuevaEntidad.NombreAbreviado = abrev;
                            
                            nuevaEntidad.PoblacionFemenina = Convert.ToInt32(poblacionFemenina);
                            nuevaEntidad.PoblacionMasculina = Convert.ToInt32(poblacionMasculina);
                            nuevaEntidad.PoblacionTotal = Convert.ToInt32(poblacionTotal);

                            conexion.EntidaFederativas.Add(nuevaEntidad);
                            conexion.SaveChanges();
                        }
                    }
                }
            }*/

            using (StreamReader archivo = File.OpenText(path))
            {
                string linea = "";

                          
                while ((linea = archivo.ReadLine()) != null)
                {

                    if(linea.Length>1){
                    // Console.WriteLine($"{contador ++}   ---   {linea}");
                    var dato = linea.Split(',');
                    var id = dato[0].Replace('"',' ');
                    var nombre  = dato[1];
                    if(nombre.Length > 1){
                        var nombreModificado = nombre.Substring(1,nombre.Length-2);
                            Console.WriteLine($"{nombreModificado}");  
                            nombre = nombreModificado;  
                    }


                    var abrev  = dato[2].Replace('"',' ');
                    var poblacionTotal = dato[3].Replace('"',' ');
                    var poblacionMasculina = dato[5].Replace('"',' ');
                    var poblacionFemenina = dato[6].Replace('"',' ');
                  
                    int entidadID = 0;
                    
                    if( int.TryParse(id,out entidadID)) {
                        using(var conexion = new ElcoBitContext()  ){

                            EntidaFederativa nuevaEntidad = new EntidaFederativa();
                            nuevaEntidad.EntidadId = entidadID;
                            nuevaEntidad.Nombre = nombre;
                            nuevaEntidad.NombreAbreviado = abrev;
                            
                            nuevaEntidad.PoblacionFemenina = Convert.ToInt32(poblacionFemenina);
                            nuevaEntidad.PoblacionMasculina = Convert.ToInt32(poblacionMasculina);
                            nuevaEntidad.PoblacionTotal = Convert.ToInt32(poblacionTotal);

                            conexion.EntidaFederativas.Add(nuevaEntidad);
                            conexion.SaveChanges();
                        }
                    }
                }
                }
            }


/*
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


            }*/

             

        }
    }
}
