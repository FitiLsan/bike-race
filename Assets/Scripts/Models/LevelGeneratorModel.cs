using UnityEngine;


namespace DataSakuraBikeRace
{
    public sealed class LevelGeneratorModel
    {
        #region Fields

        private LevelGeneratorData _levelGeneratorData;
        private PoolContext _poolContext;
        private EdgeCollider2D _edgeCollider;
        private LineRenderer _lineRenderer;

        #endregion   


        #region ClassLifeCycle

        public LevelGeneratorModel(LevelGeneratorData levelGeneratorData, PoolContext poolContext, GameObject generatorObject)
        {
            _levelGeneratorData = levelGeneratorData;
            _poolContext = poolContext;
            _edgeCollider = generatorObject.GetComponent<EdgeCollider2D>();
            _lineRenderer = generatorObject.GetComponent<LineRenderer>();
        }

        #endregion     


        #region Methods

        public void GenerateLocation()
        {
            var playerPosition = _poolContext.PlayerModel.GetPlayerPosition();
            var lastPoint = _edgeCollider.points[_edgeCollider.pointCount - 1];

            if (lastPoint.x - playerPosition.x < _levelGeneratorData.GeneratedDistance)
            {
                var oldPoints = _edgeCollider.points;
                var newPoints = new Vector2[oldPoints.Length + 1];

                for (int i = 0; i < oldPoints.Length; i++)
                {
                    newPoints[i] = oldPoints[i];
                }

                var generationRange = _levelGeneratorData.MinMaxGeneratingXY;
                var newX = Random.Range(generationRange.x, generationRange.y);
                var newY = Random.Range(generationRange.z, generationRange.w);

                newPoints[newPoints.Length - 1].x = newPoints[newPoints.Length - 2].x + newX;
                newPoints[newPoints.Length - 1].y = newPoints[newPoints.Length - 2].y + newY;

                _edgeCollider.points = newPoints;
                _lineRenderer.positionCount = newPoints.Length;

                for (int i = 0; i < newPoints.Length; i++)
                {
                    newPoints[i].y -= _levelGeneratorData.TerrainOfsset;
                    _lineRenderer.SetPosition(i, newPoints[i]);
                }
            }

            #endregion 
        }
    }
}