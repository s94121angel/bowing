using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void GetScore_AllZero_0Score()
		{
			// Arrange
			Game g = new Game();

			// Act
			RollRepeat( g, 20, 0 );

			// Assert
			Assert.AreEqual( 0, g.score() );
		}

		[Test]
		public void GetScore_AllOne_20Score()
		{
			// Arrange
			Game g = new Game();

			// Act
			RollRepeat( g, 20, 1 );

			// Assert
			Assert.AreEqual( 20, g.score() );
		}

		[Test]
		public void GetScore_SpareAdd3_16Score()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 5 );
			g.roll( 5 );
			g.roll( 3 );
			RollRepeat( g, 17, 0 );

			// Assert
			Assert.AreEqual( 16, g.score() );
		}

		[Test]
		public void GetScore_SpareInDiffFrame_Score()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 0 );
			g.roll( 10 );
			g.roll( 3 );
			g.roll( 6 );
			g.roll( 4 );
			g.roll( 6 );
			g.roll( 8 );
			RollRepeat( g, 13, 0 );

			// Assert
			Assert.AreEqual( 48, g.score() );
		}

		[Test]
		public void GetScore_SpareInDiffFrame_Score2()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 0 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 3 );
			g.roll( 6 );
			g.roll( 4 );
			g.roll( 6 );
			g.roll( 8 );
			RollRepeat( g, 11, 0 );

			// Assert
			Assert.AreEqual( 74, g.score() );
		}
		
		[Test]
		public void GetScore_SpareInDiffFrame_Score4()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 10 );
			g.roll( 2 );
			g.roll( 3 );
			g.roll( 1 );
			g.roll( 9 );
			g.roll( 6 );
			g.roll( 3 );
			g.roll( 2 );

			RollRepeat( g, 11, 0 );

			// Assert
			Assert.AreEqual( 47, g.score() );
		}

		[Test]
		public void GetScore_SpareInDiffFrame_Score5()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );

			// Assert
			Assert.AreEqual( 300, g.score() );
		}

		[Test]
		public void GetScore_SpareInDiffFrame_Score6()
		{
			// Arrange
			Game g = new Game();

			// Act
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 10 );
			g.roll( 0 );
			g.roll( 10 );

			// Assert
			Assert.AreEqual( 280, g.score() );
		}

		static void RollRepeat( Game g, int nRepTimes, int nPins )
		{
			for( int i = 0; i < nRepTimes; i++ ) {
				g.roll( nPins );
			}
		}
	}
}
