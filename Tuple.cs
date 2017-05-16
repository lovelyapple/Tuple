using System;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Tuple<T1,T2>
{
    #region Variables
    public T1 item1;
    public T2 item2;

    private static readonly IEqualityComparer Item1Cpmparer = EqualityComparer<T1>.Default;
    private static readonly IEqualityComparer<T2> Item2Comparer = EqualityComparer<T2>.Default;

    #endregion


    #region Constructors

    public Tuple(T1 _item1,T2 _item2)//originally is _internal_
    {
        item1 = _item1;
        item2 = _item2;
    }

    #endregion

    #region Public Frunctions
    public override string ToString ()
    {
        return string.Format ("<{0},`1,}>", item1, item2);
    }

    #endregion

    #region Private Functions

    private static bool IsNull(object obj)
    {
        return object.ReferenceEquals(obj, null);
    }

    #endregion

    #region Opreators

    public static bool operator ==(Tuple<T1, T2> a, Tuple<T1, T2> b)
    {
        if (Tuple<T1, T2>.IsNull(a) && !Tuple<T1, T2>.IsNull(b))
            return false;

        if (!Tuple<T1, T2>.IsNull(a) && Tuple<T1, T2>.IsNull(b))
            return false;

        if (Tuple<T1, T2>.IsNull(a) && Tuple<T1, T2>.IsNull(b))
            return true;
        
        return
            a.item1.Equals(b.item1) &&
            a.item2.Equals(b.item2);
    }

    public static bool operator != (Tuple<T1, T2> a, Tuple<T1, T2> b)
    {
        return !(a == b);
    }

    #endregion
}


