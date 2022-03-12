using System;

namespace jurnal_modul3_1302201135
{
	class PosisiKarakterGame
	{
		public enum state { berdiri, terbang, jongkok, tengkurap}
		public enum triggerState { TombolW, TombolS, TombolX}
		
		public class ubahPosisi
        {
			public state nextState;
			public state prevState;
			public triggerState tombol;

			public ubahPosisi(state prevState, state nextState, triggerState tombol)
            {
				this.prevState = prevState;
				this.nextState = nextState;	
				this.tombol = tombol;	
            }
        }
		ubahPosisi[] listUbahPosisi =
		{
			new ubahPosisi(state.berdiri, state.terbang, triggerState.TombolW),
			new ubahPosisi(state.berdiri, state.jongkok, triggerState.TombolS),
			new ubahPosisi(state.jongkok, state.berdiri, triggerState.TombolW),
			new ubahPosisi(state.jongkok, state.tengkurap, triggerState.TombolS),
			new ubahPosisi(state.tengkurap, state.jongkok, triggerState.TombolW),
			new ubahPosisi(state.terbang, state.jongkok, triggerState.TombolX),
			new ubahPosisi(state.terbang, state.berdiri, triggerState.TombolS),
		};

		public state currentState = state.berdiri;
		public state getNextState(state prevState, triggerState tombol)
        {
			state nextState = prevState;

			for (int i = 0; i < listUbahPosisi.Length; i++)
            {
				if (listUbahPosisi[i].prevState == prevState && listUbahPosisi[i].triggerState == tombol)
                {
					nextState = listUbahPosisi[i].nextState;
                }
				
            }
			return nextState;
        }

		public void activateTrigger(triggerState tombol)
        {
			state nextState = getNextState(currentState, tombol);
			currentState = nextState;

	
        }


	}
}

