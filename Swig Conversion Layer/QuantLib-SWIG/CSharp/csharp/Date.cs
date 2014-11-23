/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class Date : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Date(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Date obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Date() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Date(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

    public static Date operator+(Date d, int i) {
        return new Date(d.serialNumber() + i);
    }
    public static Date operator-(Date d, int i) {
        return new Date(d.serialNumber() - i);
    }
    public static bool operator==(Date d1, Date d2) {
        object o1 = (object)d1;
        object o2 = (object)d2;
        if (o1 == null && o2 == null)
            return true;
        if (o1 == null || o2 == null)
            return false;
        return d1.serialNumber() == d2.serialNumber();
    }
    public static bool operator!=(Date d1, Date d2) {
        object o1 = (object)d1;
        object o2 = (object)d2;
        if (o1 == null && o2 == null)
            return false;
        if (o1 == null || o2 == null)
            return true;
        return d1.serialNumber() != d2.serialNumber();
    }
    public static bool operator>(Date d1, Date d2) {
        object o1 = (object)d1;
        object o2 = (object)d2;
        if (o1 == null || o2 == null)
            return false;
        return d1.serialNumber() > d2.serialNumber();
    }
    public static bool operator<(Date d1, Date d2) {
        object o1 = (object)d1;
        object o2 = (object)d2;
        if (o1 == null || o2 == null)
            return false;
        return d1.serialNumber() < d2.serialNumber();
    }
    public override bool Equals(object o)
    {
        try
        {
            Date d = (Date)o;
            return this.serialNumber() == d.serialNumber();
        }
        catch
        {
           return false;
        }
   }
   public override int GetHashCode()
   {
       return this.serialNumber();
   }

  public Date() : this(NQuantLibcPINVOKE.new_Date__SWIG_0(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Date(int d, Month m, int y) : this(NQuantLibcPINVOKE.new_Date__SWIG_1(d, (int)m, y), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Date(int serialNumber) : this(NQuantLibcPINVOKE.new_Date__SWIG_2(serialNumber), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Weekday weekday() {
    Weekday ret = (Weekday)NQuantLibcPINVOKE.Date_weekday(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int dayOfMonth() {
    int ret = NQuantLibcPINVOKE.Date_dayOfMonth(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int dayOfYear() {
    int ret = NQuantLibcPINVOKE.Date_dayOfYear(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Month month() {
    Month ret = (Month)NQuantLibcPINVOKE.Date_month(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int year() {
    int ret = NQuantLibcPINVOKE.Date_year(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int serialNumber() {
    int ret = NQuantLibcPINVOKE.Date_serialNumber(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isLeap(int y) {
    bool ret = NQuantLibcPINVOKE.Date_isLeap(y);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date minDate() {
    Date ret = new Date(NQuantLibcPINVOKE.Date_minDate(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date maxDate() {
    Date ret = new Date(NQuantLibcPINVOKE.Date_maxDate(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date todaysDate() {
    Date ret = new Date(NQuantLibcPINVOKE.Date_todaysDate(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date endOfMonth(Date arg0) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_endOfMonth(Date.getCPtr(arg0)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isEndOfMonth(Date arg0) {
    bool ret = NQuantLibcPINVOKE.Date_isEndOfMonth(Date.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextWeekday(Date arg0, Weekday arg1) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_nextWeekday(Date.getCPtr(arg0), (int)arg1), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nthWeekday(uint n, Weekday arg1, Month m, int y) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_nthWeekday(n, (int)arg1, (int)m, y), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date Add(int days) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_Add__SWIG_0(swigCPtr, days), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date Subtract(int days) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_Subtract__SWIG_0(swigCPtr, days), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date Add(Period arg0) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_Add__SWIG_1(swigCPtr, Period.getCPtr(arg0)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date Subtract(Period arg0) {
    Date ret = new Date(NQuantLibcPINVOKE.Date_Subtract__SWIG_1(swigCPtr, Period.getCPtr(arg0)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date(string str, string fmt) : this(NQuantLibcPINVOKE.new_Date__SWIG_3(str, fmt), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public int weekdayNumber() {
    int ret = NQuantLibcPINVOKE.Date_weekdayNumber(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string __str__() {
    string ret = NQuantLibcPINVOKE.Date___str__(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string __repr__() {
    string ret = NQuantLibcPINVOKE.Date___repr__(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ISO() {
    string ret = NQuantLibcPINVOKE.Date_ISO(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
