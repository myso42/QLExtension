/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class ForwardRateAgreement : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ForwardRateAgreement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.ForwardRateAgreement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ForwardRateAgreement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ForwardRateAgreement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_ForwardRateAgreement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ForwardRateAgreement(Date valueDate, Date maturityDate, Position.Type type, double strikeForwardRate, double notionalAmount, IborIndex index, YieldTermStructureHandle discountCurve) : this(NQuantLibcPINVOKE.new_ForwardRateAgreement__SWIG_0(Date.getCPtr(valueDate), Date.getCPtr(maturityDate), (int)type, strikeForwardRate, notionalAmount, IborIndex.getCPtr(index), YieldTermStructureHandle.getCPtr(discountCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ForwardRateAgreement(Date valueDate, Date maturityDate, Position.Type type, double strikeForwardRate, double notionalAmount, IborIndex index) : this(NQuantLibcPINVOKE.new_ForwardRateAgreement__SWIG_1(Date.getCPtr(valueDate), Date.getCPtr(maturityDate), (int)type, strikeForwardRate, notionalAmount, IborIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double spotIncome(YieldTermStructureHandle discount) {
    double ret = NQuantLibcPINVOKE.ForwardRateAgreement_spotIncome(swigCPtr, YieldTermStructureHandle.getCPtr(discount));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double spotValue() {
    double ret = NQuantLibcPINVOKE.ForwardRateAgreement_spotValue(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRate forwardRate() {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.ForwardRateAgreement_forwardRate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
