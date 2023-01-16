using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace BuzonDeSugerencias.Helper
{
	public static class Captcha
	{
		private const string Letters = "2346789ABCDEFGHJKLMNPRTUVWXYZ";

		public static string GenerateCaptchaCode()
		{
			Random rand = new Random();
			int maxRand = "2346789ABCDEFGHJKLMNPRTUVWXYZ".Length - 1;
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < 4; i++)
			{
				int index = rand.Next(maxRand);
				sb.Append("2346789ABCDEFGHJKLMNPRTUVWXYZ"[index]);
			}
			return sb.ToString();
		}

		public static bool ValidateCaptchaCode(string userInputCaptcha, HttpContext context)
		{
			bool isValid = userInputCaptcha == context.Session.GetString("CaptchaCode");
			context.Session.Remove("CaptchaCode");
			return isValid;
		}

		public static CaptchaResult GenerateCaptchaImage(int width, int height, string captchaCode)
		{
			Bitmap baseMap = new Bitmap(width, height);
			Random rand;
			try
			{
				Graphics graph = Graphics.FromImage(baseMap);
				try
				{
					rand = new Random();
					graph.Clear(GetRandomLightColor());
					DrawCaptchaCode();
					AdjustRippleEffect();
					MemoryStream ms = new MemoryStream();
					baseMap.Save(ms, ImageFormat.Png);
					return new CaptchaResult
					{
						CaptchaCode = captchaCode,
						CaptchaByteData = ms.ToArray(),
						Timestamp = DateTime.Now
					};
					void DrawCaptchaCode()
					{
						SolidBrush fontBrush = new SolidBrush(Color.Black);
						int fontSize = GetFontSize(width, captchaCode.Length);
						Font font = new Font(FontFamily.GenericSerif, fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
						for (int i = 0; i < captchaCode.Length; i++)
						{
							fontBrush.Color = GetRandomDeepColor();
							int shiftPx = fontSize / 6;
							float x2 = i * fontSize + rand.Next(-shiftPx, shiftPx) + rand.Next(-shiftPx, shiftPx);
							int maxY = height - fontSize;
							if (maxY < 0)
							{
								maxY = 0;
							}
							float y2 = rand.Next(0, maxY);
							graph.DrawString(captchaCode[i].ToString(), font, fontBrush, x2, y2);
						}
					}
					Color GetRandomLightColor()
					{
						int low = 180;
						int high = 255;
						int nRend = rand.Next(high) % (high - low) + low;
						int nGreen = rand.Next(high) % (high - low) + low;
						int nBlue = rand.Next(high) % (high - low) + low;
						return Color.FromArgb(nRend, nGreen, nBlue);
					}
				}
				finally
				{
					if (graph != null)
					{
						((IDisposable)graph).Dispose();
					}
				}
			}
			finally
			{
				if (baseMap != null)
				{
					((IDisposable)baseMap).Dispose();
				}
			}
			void AdjustRippleEffect()
			{
				short nWave = 6;
				int nWidth = baseMap.Width;
				int nHeight = baseMap.Height;
				Point[,] pt = new Point[nWidth, nHeight];
				for (int x = 0; x < nWidth; x++)
				{
					for (int y = 0; y < nHeight; y++)
					{
						double xo = (double)nWave * Math.Sin(6.283 * (double)y / 128.0);
						double yo = (double)nWave * Math.Cos(6.283 * (double)x / 128.0);
						double newX = (double)x + xo;
						double newY = (double)y + yo;
						if (newX > 0.0 && newX < (double)nWidth)
						{
							pt[x, y].X = (int)newX;
						}
						else
						{
							pt[x, y].X = 0;
						}
						if (newY > 0.0 && newY < (double)nHeight)
						{
							pt[x, y].Y = (int)newY;
						}
						else
						{
							pt[x, y].Y = 0;
						}
					}
				}
				Bitmap bSrc = (Bitmap)baseMap.Clone();
				BitmapData bitmapData = baseMap.LockBits(new Rectangle(0, 0, baseMap.Width, baseMap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
				BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
				int scanline = bitmapData.Stride;
				IntPtr scan0 = bitmapData.Scan0;
				IntPtr srcScan0 = bmSrc.Scan0;
				baseMap.UnlockBits(bitmapData);
				bSrc.UnlockBits(bmSrc);
				bSrc.Dispose();
			}
			static int GetFontSize(int imageWidth, int captchCodeCount)
			{
				int averageSize = imageWidth / captchCodeCount;
				return Convert.ToInt32(averageSize);
			}
			Color GetRandomDeepColor()
			{
				int redlow = 160;
				int greenLow = 100;
				int blueLow = 160;
				return Color.FromArgb(rand.Next(redlow), rand.Next(greenLow), rand.Next(blueLow));
			}
		}
	}
}
