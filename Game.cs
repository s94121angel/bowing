namespace Bowling
{
	public class Game
	{
		int m_nCurrentRoll = 0;
		int[] m_nRollsArray = new int[ 20 ];
		const int ALL_frame = 10;

		public void roll( int nPins )
		{
			//m_nScore += nPins;
			m_nRollsArray[ m_nCurrentRoll ] = nPins;
			m_nCurrentRoll++;
		}

		public int score()
		{
			int nScore = 0;
			int nFrameIndex = 0;
			for( int frame = 0; frame < ALL_frame; frame++ ) {
				if( isStrike( nFrameIndex ) ) {
					nScore = nScore + 10 + m_nRollsArray[ nFrameIndex + 1 ] + m_nRollsArray[ nFrameIndex + 2];
					nFrameIndex++;
					continue;
				}

				if( isSpare( nFrameIndex ) ) {

					nScore = nScore + 10 + m_nRollsArray[ nFrameIndex + 2 ];

				}
				else {
					nScore = nScore + m_nRollsArray[ nFrameIndex ] + m_nRollsArray[ nFrameIndex + 1 ];
				}
				nFrameIndex = nFrameIndex + 2;
			}
			return nScore;
		}

		bool isSpare( int nFrameIndex )
		{
			int nFramePins = m_nRollsArray[ nFrameIndex ] + m_nRollsArray[ nFrameIndex + 1 ];
			if( nFramePins != 10 ) {
				return false;
			}
			return true;
		}

		bool isStrike( int nFrameIndex )
		{
			int nFramePins = m_nRollsArray[ nFrameIndex ];
			if( nFramePins != 10 ) {
				return false;
			}
			return true;
		}
	}
}
