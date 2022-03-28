//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.BuiltinInterfaces;

namespace RosMessageTypes.Control
{
    [Serializable]
    public class QueryTrajectoryStateRequest : Message
    {
        public const string k_RosMessageName = "control_msgs/QueryTrajectoryState";
        public override string RosMessageName => k_RosMessageName;

        public TimeMsg time;

        public QueryTrajectoryStateRequest()
        {
            this.time = new TimeMsg();
        }

        public QueryTrajectoryStateRequest(TimeMsg time)
        {
            this.time = time;
        }

        public static QueryTrajectoryStateRequest Deserialize(MessageDeserializer deserializer) => new QueryTrajectoryStateRequest(deserializer);

        private QueryTrajectoryStateRequest(MessageDeserializer deserializer)
        {
            this.time = TimeMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.time);
        }

        public override string ToString()
        {
            return "QueryTrajectoryStateRequest: " +
            "\ntime: " + time.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}