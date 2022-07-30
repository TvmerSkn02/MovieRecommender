using System;
using Microsoft.ML.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender
{
    internal class MovieRatingData
    {
        public class MovieRating
        {
            [LoadColumn(0)]
            public float userId;
            [LoadColumn(1)]
            public float movieId;
            [LoadColumn(2)]
            public float Label;
        }
        public class MovieRatingPrediction
        {
            public float Label;
            public float Score;
        }
    }
}
