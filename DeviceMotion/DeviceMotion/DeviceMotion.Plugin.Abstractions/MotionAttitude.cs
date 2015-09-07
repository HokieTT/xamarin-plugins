using System;

namespace DeviceMotion.Plugin.Abstractions
{
	/// <summary>
	/// DeviceMotion set of processed output.
	/// </summary>
	public class MotionAttitude : MotionValue
	{
		/// <summary>
		/// Gets or sets the pitch.
		/// </summary>
		/// <value>The pitch.</value>
		public double Pitch { get; set; }
		/// <summary>
		/// Gets or sets the yaw.
		/// </summary>
		/// <value>The yaw.</value>
		public double Yaw { get; set; }
		/// <summary>
		/// Gets or sets the roll.
		/// </summary>
		/// <value>The roll.</value>
		public double Roll { get; set; }

		/// <summary>
		/// Vector to string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("Pitch={0}, Yaw={0}, Roll={0}, Gravity={0}", Pitch, Yaw, Roll);
		}


	}
}

