/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class SwaptionVolatilityMatrix : SwaptionVolatilityStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwaptionVolatilityMatrix(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SwaptionVolatilityMatrix_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwaptionVolatilityMatrix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwaptionVolatilityMatrix() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwaptionVolatilityMatrix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SwaptionVolatilityMatrix(Date referenceDate, DateVector dates, PeriodVector lengths, Matrix vols, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_SwaptionVolatilityMatrix__SWIG_0(Date.getCPtr(referenceDate), DateVector.getCPtr(dates), PeriodVector.getCPtr(lengths), Matrix.getCPtr(vols), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwaptionVolatilityMatrix(Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, PeriodVector swapTenors, QuoteHandleVectorVector vols, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_SwaptionVolatilityMatrix__SWIG_1(Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), PeriodVector.getCPtr(swapTenors), QuoteHandleVectorVector.getCPtr(vols), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwaptionVolatilityMatrix(Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, PeriodVector swapTenors, Matrix vols, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_SwaptionVolatilityMatrix__SWIG_2(Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), PeriodVector.getCPtr(swapTenors), Matrix.getCPtr(vols), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
