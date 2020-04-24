using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3_ralasic
{
    class ArrayGenerator
    {
        private static ArrayGenerator instance;
        private Random generator;

        private ArrayGenerator()
        {
            this.generator = new Random();
        }

        public static ArrayGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new ArrayGenerator();
            }
            return instance;
        }

        public double[][] generateRandomDoubleMatrix(int row, int column)
        {
            double[][] matrix = new double[row][];
            for (int i = 0; i < row; i++)
            {
                matrix[i] = new double[column];
            }
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            return matrix;
        }
    }
}
