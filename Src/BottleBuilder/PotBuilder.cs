using System;
using KompasConnector;
using PotParameters;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;



namespace PotBuilder
{
    /// <summary>
    /// Class for build pot 
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Variable for connecting with Kompas
        /// </summary>
        private Konnector _connector;

        /// <summary>
        /// Pot parameters
        /// </summary>
        private Parameters _parameters;

        /// <summary>
        /// Variable pointing to sketchPoint
        /// </summary>
        private ksSketchDefinition _sketch;

        /// <summary>
        /// Method for building pot
        /// </summary>
        /// <param name="konnector">Variable for connecting with Kompas</param>
        /// <param name="parameters">List of parameters</param>
        public void BuildPot(Konnector konnector, Parameters parameters)
        {
            _connector = konnector;
            _connector.GetNewPart();
            _parameters = parameters;
            
            if (_parameters.IsPotStraight)
            {
                BuildPotBase();
                BuildSecondPotBase();
            }
            else
            {
                BuildAnotherPot();
            }
        }

        /// <summary>
        /// Method for building base of the pot
        /// </summary>
        private void BuildPotBase()
        {
            var sketchPoint = new Point3D
            {
                X = 0,
                Y = 0,
                Z = 0
            };

            _sketch = CreateSketch(Obj3dType.o3d_planeXOY, true, sketchPoint);

            var circleCentre = new Point2D
            {
                X = 0,
                Y = 0
            };
            double circleRadius = _parameters.Width / 2 - _parameters.WallThickness;

            CreateCircle(_sketch, circleCentre, circleRadius);

            var pressThickness = _parameters.WallThickness;
            double pressHeight = _parameters.Height / 4 * 3;
            PressOutSketchThickness(_sketch, pressHeight, pressThickness, true, 0);

            pressThickness = _parameters.Bottom * (-1);
            PressOutSketch(_sketch, pressThickness, false, 2);

            var filletPoint = new Point3D
            {
                X = _parameters.Width / 2,
                Y = 0,
                Z = 0
            };
            CreateEdgeFillet(filletPoint, _parameters.WallThickness);

            sketchPoint = new Point3D
            {
                X = _parameters.Width / 2 - 2,
                Y = 0,
                Z = _parameters.Height / 4 * 3
            };
            _sketch = CreateSketch(Obj3dType.o3d_sketch, false, sketchPoint);
        }

        private void BuildSecondPotBase()
        {
            var circleCentre = new Point2D
            {
                X = 0,
                Y = 0
            };

            double circleRadius = _parameters.Width / 2;
            CreateCircle(_sketch, circleCentre, circleRadius);

            var pressThickness = _parameters.WallThickness;
            double pressHeight = _parameters.TopHeight;
            PressOutSketchThickness(_sketch, pressHeight, pressThickness, true, 0);

        }

        private void BuildAnotherPot()
        {
            var sketchPoint = new Point3D
            {
                X = 0,
                Y = 0,
                Z = 0
            };

            _sketch = CreateSketch(Obj3dType.o3d_planeXOY, true, sketchPoint);

            var circleCentre = new Point2D
            {
                X = 0,
                Y = 0
            };
            double circleRadius = _parameters.Width / 2 - _parameters.WallThickness;
            CreateCircle(_sketch, circleCentre, circleRadius);

            double angle = _parameters.AnglePot;

            var pressThickness = _parameters.WallThickness;
            double pressHeight = _parameters.Height / 4 * 3;
            PressOutSketchThickness(_sketch, pressHeight, pressThickness, true, angle);

            pressThickness = _parameters.Bottom * (-1);
            PressOutSketch(_sketch, pressThickness, false, 0);

            var filletPoint = new Point3D
            {
                X = _parameters.Width / 2,
                Y = 0,
                Z = 0
            };
            CreateEdgeFillet(filletPoint, _parameters.WallThickness);

            sketchPoint = new Point3D
            {
                X = _parameters.Width / 2 - 2,
                Y = 0,
                Z = _parameters.Height / 4 * 3
            };
            _sketch = CreateSketch(Obj3dType.o3d_sketch, false, sketchPoint);

        }

        /// <summary>
        /// Method for creating sketch
        /// </summary>
        /// <param name="planeType">Type of the plane</param>
        /// <param name="isFirstSketch"></param>
        /// <param name="point">The point where the sketch will be created</param>
        /// <returns>Definition of the sketchPoint</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType,
            bool isFirstSketch, Point3D point)
        {
            ksEntity plane = (ksEntity)_connector
                .KsPart
                .GetDefaultEntity((short)planeType);

            var sketchPoint = (ksEntity)_connector
                .KsPart
                .NewEntity((short)Obj3dType.o3d_sketch);

            var sketchDefinition = (ksSketchDefinition)sketchPoint.GetDefinition();
            if (!isFirstSketch)
            {
                ksEntityCollection iCollection =
                    _connector.KsPart.EntityCollection((short)Obj3dType.o3d_face);
                iCollection.SelectByPoint(point.X, point.Y, point.Z);
                plane = iCollection.First();
            }
            sketchDefinition.SetPlane(plane);

            sketchPoint.Create();
            return sketchDefinition;
        }

        /// <summary>
        /// Method for creating circle on sketchPoint
        /// </summary>
        /// <param name="sketchPoint">sketchPoint</param>
        /// <param name="centre">Coordinates of centre circle</param>
        /// <param name="radius"> Radius of the circle</param>
        private void CreateCircle(ksSketchDefinition sketchPoint, Point2D centre, double radius)
        {
            var circle = (ksCircleParam)_connector
                .Kompas
                .GetParamStruct((short)StructType2DEnum.ko_CircleParam);

            circle.style = 1;
            var doc2D = (ksDocument2D)_sketch.BeginEdit();
            doc2D.ksCircle(centre.X, centre.Y, radius, circle.style);
            sketchPoint.EndEdit();
        }

        /// <summary>
        /// Extrude from sketchPoint
        /// </summary>
        /// <param name="sketchPoint">sketchPoint</param>
        /// <param name="thickness">Thickness of extrude</param>
        /// <param name="side">Side</param>
        /// <param name="draftValue">Draft value</param>
        private void PressOutSketch(
            ksSketchDefinition sketchPoint,
            double thickness, bool side, double draftValue)
        {
            var extrusionEntity = (ksEntity)_connector
                .KsPart
                .NewEntity((short)Obj3dType.o3d_bossExtrusion);

            var extrusionDefinition = (ksBossExtrusionDefinition)extrusionEntity
                .GetDefinition();

            extrusionDefinition.SetSideParam(side, 0, thickness);

            extrusionDefinition.SetSketch(sketchPoint);
            ExtrusionParam extrusionParam = extrusionDefinition.ExtrusionParam();
            extrusionParam.depthNormal = thickness;
            extrusionParam.draftValueNormal = draftValue;

            extrusionEntity.Create();
        }

        /// <summary>
        /// Extrude a thin-walled feature from sketchPoint
        /// </summary>
        /// <param name="sketchPoint">sketchPoint</param>
        /// <param name="height">Height of extrude</param>
        /// <param name="wallThickness">Thickness of extrude</param>
        /// <param name="side">Side</param>
        /// <param name="draftValue">Draft value</param>
        private void PressOutSketchThickness(ksSketchDefinition sketchPoint,
            double height, double wallThickness, bool side, double draftValue)
        {

            var extrusionEntity = (ksEntity)_connector
                .KsPart
                .NewEntity((short)Obj3dType.o3d_baseExtrusion);

            var extrusionDefinition = (ksBaseExtrusionDefinition)extrusionEntity
                .GetDefinition();

            extrusionDefinition.SetSideParam(side, 0, height);
            extrusionDefinition.SetThinParam(true, 0, wallThickness);


            extrusionDefinition.SetSketch(sketchPoint);
            ExtrusionParam extrusionParam = extrusionDefinition.ExtrusionParam();
            extrusionParam.draftValueNormal = draftValue;
            extrusionEntity.Create();
        }

        /// <summary>
        /// Add filletPoint in filletPoint array
        /// </summary>
        /// <param name="radius">filletPoint radius</param>
        /// <returns name="filletEntity">filletPoint entity</returns>
        private ksEntity AddFillet(double radius)
        {
            var filletEntity = (ksEntity)_connector
                .KsPart
                .NewEntity((short)Obj3dType.o3d_fillet);

            var filletDefinition = (ksFilletDefinition)filletEntity.GetDefinition();

            filletDefinition.radius = radius;

            filletDefinition.tangent = true;

            return filletEntity;
        }

        /// <summary>
        /// Create сhamfer
        /// </summary>
        /// <param name="point">Coordinates pointing to a face to be сhamfered</param>
        /// <param name="distance1"></param>
        /// <param name="distance2"></param>
        private void CreateChamfer(Point3D point, double distance1, double distance2)
        {
            var chamferEntity = (ksEntity)_connector
                .KsPart
                .NewEntity((short)Obj3dType.o3d_chamfer);

            var chamferDefinition = (ksChamferDefinition)chamferEntity.GetDefinition();
            chamferDefinition.SetChamferParam(true, distance1, distance2);

            ksEntityCollection iArray = chamferDefinition.array();
            ksEntityCollection iCollection = _connector.KsPart.EntityCollection((short)Obj3dType.o3d_edge);

            iCollection.SelectByPoint(point.X, point.Y, point.Z);

            var iEdge = iCollection.Last();
            iArray.Add(iEdge);

            chamferEntity.Create();
        }

        /// <summary>
        /// Create filletPoint of the face
        /// </summary>
        /// <param name="point">Coordinates pointing to a face or surface to be filleted</param>
        /// <param name="radius">filletPoint radius</param>
        private void CreateFaceFillet(Point3D point, double radius)
        {
            var filletEntity = AddFillet(radius);
            var filletDefinition = (ksFilletDefinition)filletEntity.GetDefinition();

            ksEntityCollection iArray = filletDefinition.array();
            ksEntityCollection iCollection = _connector.KsPart.EntityCollection((short)Obj3dType.o3d_face);

            iCollection.SelectByPoint(point.X, point.Y, point.Z);
            var iFace = iCollection.First();
            iArray.Add(iFace);

            filletEntity.Create();
        }

        /// <summary>
        /// Create filletPoint of the edge
        /// </summary>
        /// <param name="point">Coordinates pointing to a face or surface to be filleted</param>
        /// <param name="radius">filletPoint radius</param>
        private void CreateEdgeFillet(Point3D point, double radius)
        {
            ksEntity filletEntity = AddFillet(radius);
            var filletDefinition = (ksFilletDefinition)filletEntity.GetDefinition();

            ksEntityCollection iArray = filletDefinition.array();
            ksEntityCollection iCollection = _connector.KsPart.EntityCollection((short)Obj3dType.o3d_edge);

            iCollection.SelectByPoint(point.X, point.Y, point.Z);
            var iEdge = iCollection.Last();
            // iArray.Add(iEdge);

            filletEntity.Create();
        }
    }
}
