/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class NumericHaganPricer : CmsCouponPricer {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NumericHaganPricer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.NumericHaganPricer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NumericHaganPricer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NumericHaganPricer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_NumericHaganPricer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public NumericHaganPricer(SwaptionVolatilityStructureHandle v, GFunctionFactory.YieldCurveModel model, QuoteHandle meanReversion, double lowerLimit, double upperLimit, double precision) : this(NQuantLibcPINVOKE.new_NumericHaganPricer__SWIG_0(SwaptionVolatilityStructureHandle.getCPtr(v), (int)model, QuoteHandle.getCPtr(meanReversion), lowerLimit, upperLimit, precision), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumericHaganPricer(SwaptionVolatilityStructureHandle v, GFunctionFactory.YieldCurveModel model, QuoteHandle meanReversion, double lowerLimit, double upperLimit) : this(NQuantLibcPINVOKE.new_NumericHaganPricer__SWIG_1(SwaptionVolatilityStructureHandle.getCPtr(v), (int)model, QuoteHandle.getCPtr(meanReversion), lowerLimit, upperLimit), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumericHaganPricer(SwaptionVolatilityStructureHandle v, GFunctionFactory.YieldCurveModel model, QuoteHandle meanReversion, double lowerLimit) : this(NQuantLibcPINVOKE.new_NumericHaganPricer__SWIG_2(SwaptionVolatilityStructureHandle.getCPtr(v), (int)model, QuoteHandle.getCPtr(meanReversion), lowerLimit), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumericHaganPricer(SwaptionVolatilityStructureHandle v, GFunctionFactory.YieldCurveModel model, QuoteHandle meanReversion) : this(NQuantLibcPINVOKE.new_NumericHaganPricer__SWIG_3(SwaptionVolatilityStructureHandle.getCPtr(v), (int)model, QuoteHandle.getCPtr(meanReversion)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
