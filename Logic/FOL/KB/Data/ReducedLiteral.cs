namespace AIMA.Core.Logic.FOL.KB.Data
{
    using System;
    using System.Collections;
    using System.Text;
    using AIMA.Core.Logic.FOL.Parsing.AST;


    /**
     * @see http://logic.stanford.edu/classes/cs157/2008/lectures/lecture13.pdf
     */

    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class ReducedLiteral : Literal
    {
        private String strRep = null;

        public ReducedLiteral(AtomicSentence atom): base(atom)
        {
            
        }

        public ReducedLiteral(AtomicSentence atom, bool negated) : base(atom, negated)
        {
           
        }

        public override Literal newInstance(AtomicSentence atom)
        {
            return new ReducedLiteral(atom, isNegativeLiteral());
        }

        public override String ToString()
        {
            if (null == strRep)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                if (isNegativeLiteral())
                {
                    sb.Append("~");
                }
                sb.Append(getAtomicSentence().ToString());
                sb.Append("]");
                strRep = sb.ToString();
            }

            return strRep;
        }
    }
}