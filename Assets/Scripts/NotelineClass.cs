using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NotelineClass {

	public struct NoteData
	{
		public List<Notes> bars;
	}


	public struct Notes
	{
		public int left;
		public int middle;
		public int right;
	}

}
