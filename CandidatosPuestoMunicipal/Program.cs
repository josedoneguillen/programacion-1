/*
 * El  director  de una  firma  consultora,  nos  pide  que  analicemos  un  archivo conteniendo una lista de candidatos a un puesto municipal; 
 * el archivo tiene la estructura siguiente:
 * Candidato, Cantidad votos,Sexo del votante
 * Nuestra tarea será presentar un informe conteniendo:
 * Determinar la cantidad de votos emitidos
 * Cantidad de votos por género (hombre, mujer)
 * El candidato con mayor votación
 * % de votos obtenido por cada candidato.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CandidatosPuestoMunicipal
{
    class Program
    {

        // Declaracion de estructura de cantidato
        [Serializable]
        public struct Candidato
        {
            public string NombreCandidato { get; set; }
            public List<char> Votos { get; set; }
        }

        static void Main(string[] args)
        {
            // Declaracion de lista de candidatos
            List<Candidato> Candidatos = new List<Candidato>();

            // Declaracion de lista de candidatos
            List<Double> VotosPorCandidato = new List<Double>();

            // Declaracion de variables cuantitativas para el informe
            int VotosEmitidos = 0, VotosHombre = 0, VotosMujer = 0;
            string CandidatoMasVotado = "";

            // Crear datos de candidato y votos
            Candidatos.Add(new Candidato { NombreCandidato = "Carolina Mejía", Votos = new List<char>() });
            Candidatos.Add(new Candidato { NombreCandidato = "Domingo Contreras", Votos = new List<char>() });
            Candidatos.Add(new Candidato { NombreCandidato = "David Collado", Votos = new List<char>() });

            Candidatos[0].Votos.Add('M');
            Candidatos[0].Votos.Add('F');
            Candidatos[0].Votos.Add('M');
            Candidatos[0].Votos.Add('M');

            Candidatos[1].Votos.Add('M');
            Candidatos[1].Votos.Add('M');

            Candidatos[2].Votos.Add('M');
            Candidatos[2].Votos.Add('M');
            Candidatos[2].Votos.Add('F');

            // Crear archivo
            Stream stream = File.Open("Candidatos.dat", FileMode.Create);

            // Crear Formateador Binario
            BinaryFormatter bf = new BinaryFormatter();

            // Serializar objeto y almacenarlo en el archivo
            bf.Serialize(stream, Candidatos);

            // Cerrar el archivo
            stream.Close();

            // Limpiar lista de candidatos
            Candidatos = null;

            // Abrir archivo
            stream = File.Open("Candidatos.dat", FileMode.Open);

            // Crear nuevo Formateador Binario
            bf = new BinaryFormatter();

            // Leer archivo
            Candidatos = (List<Candidato>)bf.Deserialize(stream);

            // Cerrar el archivo
            stream.Close();

            // Crear candidato anterior para comparaciones
            Candidato candidatoAnterior = new Candidato { NombreCandidato = "", Votos = new List<char>() };


            // Recorrer los datos leidos del archivo para calcular reporte
            foreach (Candidato candidato in Candidatos)
            {
                // Validacion candidato mas votado
                if (candidato.Votos.Count > candidatoAnterior.Votos.Count)
                {
                    CandidatoMasVotado = candidato.NombreCandidato;
                }

                // Incrementar total general de votos
                VotosEmitidos += candidato.Votos.Count;

                // Recorrer los votos de cada candidato
                foreach (char voto in candidato.Votos)
                {

                    // Validacion para contar votos mujeres
                    if (voto == 'F')
                    {
                        VotosMujer++;
                    }

                    // Validacion para contar votos hombres
                    if (voto == 'M')
                    {
                        VotosHombre++;
                    }
                }

                // Almacenar candidato anterior para comprar el na siguiente iteracion
                candidatoAnterior = candidato;

            }

            // Imprimir datos generales
            Console.WriteLine("Total de votos emitidos: " + VotosEmitidos + ", Votos de Mujeres: " + VotosMujer + ", Votos de Hombres: " + VotosHombre + ", Candidato con más votos: " + CandidatoMasVotado);

            // Ciclo foreach para imprimir los resultados por candidato
            foreach (Candidato candidato in Candidatos)
            {
                Console.WriteLine("Nombre: " + candidato.NombreCandidato + ", Votos: " + candidato.Votos.Count + ", Procentaje: " + ( ( Convert.ToDouble(candidato.Votos.Count) / VotosEmitidos ) * 100 ).ToString("F") + "%");
            }


            // Esperar letra para cerrar
            Console.ReadKey();
        }
    }
}
