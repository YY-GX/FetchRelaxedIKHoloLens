//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.RelaxedIkRos1
{
    [Serializable]
    public class JointAnglesMsg : Message
    {
        public const string k_RosMessageName = "relaxed_ik_ros1/JointAngles";
        public override string RosMessageName => k_RosMessageName;

        public Std.HeaderMsg header;
        public Std.Float64MultiArrayMsg angles;

        public JointAnglesMsg()
        {
            this.header = new Std.HeaderMsg();
            this.angles = new Std.Float64MultiArrayMsg();
        }

        public JointAnglesMsg(Std.HeaderMsg header, Std.Float64MultiArrayMsg angles)
        {
            this.header = header;
            this.angles = angles;
        }

        public static JointAnglesMsg Deserialize(MessageDeserializer deserializer) => new JointAnglesMsg(deserializer);

        private JointAnglesMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.angles = Std.Float64MultiArrayMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.angles);
        }

        public override string ToString()
        {
            return "JointAnglesMsg: " +
            "\nheader: " + header.ToString() +
            "\nangles: " + angles.ToString();
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
