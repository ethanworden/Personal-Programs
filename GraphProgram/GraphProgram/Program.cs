using System;
using System.Collections;
using System.Text;


class RandomAdjancencyMatrix
{

    public class Adj_m
    {
        Random random = new Random();
        internal int graph_size;
        internal int[,] matrix;
        public bool[] visited;
        
        //the constructor for class Adj_m (adjancency matrix)
        public Adj_m()
        {
            //Read an external adjacency matrix;
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\ethan\OneDrive\Desktop\matrix\matrix44.txt"); //substitute your path here
            string s;
            int size = Convert.ToInt32(file.ReadLine());
            int counter = 0;
            matrix = new int[size, size];
            while ((s = file.ReadLine()) != null)
            {
                string[] arr = s.Split(' '); //just one blank as separator
                for (int i = 0; i < arr.Length; i++)
                {
                    matrix[counter, i] = Convert.ToInt32(arr[i]);
                    //Console.WriteLine(arr[i]);
                   // Console.WriteLine($"{counter} {i}");
                    //Console.WriteLine(matrix[counter,i]);

                }
                counter++;
            }
            file.Close();

            graph_size = size;
            visited = new bool[size];

        }

        //this method will visit all vertices that are
        //directly and indirectly connected to vertex i
        public void Connected(int i)
        {
            visited[i] = true;

            for (int j = 0; j < graph_size; j++)
            {
                if ((matrix[i, j] != 0) && (visited[j] == false))
                {
                    visited[j] = true;
                    Connected(j);
                }
            }
        }




        public void BellmanFord(int k)
        {
            int temp;
            int[] dist = new int[graph_size];
            string[] path = new string[graph_size];


            for (int i = 0; i < dist.Length;i++) //set all values to "infinity" for distance
            { 
                dist[i] = int.MaxValue;
            }
            dist[k] = 0;
            path[k] = $"{k}";

            for(int n = 0; n < graph_size; n++) { 
            for (int i = 0; i < graph_size; i++)
            {
                if (dist[i] != int.MaxValue)
                {
                        for (int j = 0; j < graph_size; j++)
                        {
                            if (matrix[i, j] != 0)
                            {
                                temp = dist[i] + matrix[i, j];
                                //dist[i] is the distance from src to i that has been found so far to which I now add the distance from i to j. If this distance
                                //is smaller than the distance from src to j than I have found a better path, i.e. the previously found path from src to j is updated
                                //by a new (shorter) path that goes through through i.
                                if (temp < dist[j])
                                {
                                    dist[j] = temp;
                                    path[j] = path[i] + ", " + Convert.ToString(j);
                                }
                            }
                        }
                    }                    
                }
            }

            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine($"The shortest path to {i} is going: {path[i]}");
                Console.WriteLine($"Total distance to {i} is: {dist[i]}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }





       public void Print_matrix()
        {
            Console.WriteLine("{0}", graph_size);
            for (int i = 0; i < graph_size; i++)
            {
                //file.Write("\n {0} = ", i);
                for (int j = 0; j < graph_size; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }





    }



    static void read()
    {

    }




    static void Main()
    {

     //   Console.Write("\n\nEnter number of vertices in graph: ");
       // int size = Convert.ToInt32(Console.ReadLine());

        //Create a random adjacency matrix of given size
        Adj_m adj_matrix = new Adj_m();

        //Print the matrix
        //Print_matrix(size, adj_matrix.matrix);

        adj_matrix.Print_matrix();
        Console.Write("\n\nEnter a vertex and show the shortest paths for all vertices that it is connected to: ");
        int k = Convert.ToInt32(Console.ReadLine());

        adj_matrix.Connected(k); 
        for (int i = 0; i < adj_matrix.graph_size; i++)
        {
            if ((adj_matrix.visited[i] == true) & (i != k))
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
        
        adj_matrix.BellmanFord(k);

        Console.WriteLine();
        Console.ReadKey();
    }
}
