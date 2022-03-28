//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.FetchUnity
{
    [Serializable]
    public class PoseQueryServiceResponse : Message
    {
        public const string k_RosMessageName = "fetch_unity/PoseQueryService";
        public override string RosMessageName => k_RosMessageName;

        public Moveit.RobotTrajectoryMsg[] trajectories;
        public Geometry.PoseMsg end_pose;

        public PoseQueryServiceResponse()
        {
            this.trajectories = new Moveit.RobotTrajectoryMsg[0];
            this.end_pose = new Geometry.PoseMsg();
        }

        public PoseQueryServiceResponse(Moveit.RobotTrajectoryMsg[] trajectories, Geometry.PoseMsg end_pose)
        {
            this.trajectories = trajectories;
            this.end_pose = end_pose;
        }

        public static PoseQueryServiceResponse Deserialize(MessageDeserializer deserializer) => new PoseQueryServiceResponse(deserializer);

        private PoseQueryServiceResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.trajectories, Moveit.RobotTrajectoryMsg.Deserialize, deserializer.ReadLength());
            this.end_pose = Geometry.PoseMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.trajectories);
            serializer.Write(this.trajectories);
            serializer.Write(this.end_pose);
        }

        public override string ToString()
        {
            return "PoseQueryServiceResponse: " +
            "\ntrajectories: " + System.String.Join(", ", trajectories.ToList()) +
            "\nend_pose: " + end_pose.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}