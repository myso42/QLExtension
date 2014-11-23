/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class ZeroCouponBond : Bond {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ZeroCouponBond(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.ZeroCouponBond_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ZeroCouponBond obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ZeroCouponBond() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_ZeroCouponBond(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ZeroCouponBond(uint settlementDays, Calendar calendar, double faceAmount, Date maturityDate, BusinessDayConvention paymentConvention, double redemption, Date issueDate) : this(NQuantLibcPINVOKE.new_ZeroCouponBond__SWIG_0(settlementDays, Calendar.getCPtr(calendar), faceAmount, Date.getCPtr(maturityDate), (int)paymentConvention, redemption, Date.getCPtr(issueDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ZeroCouponBond(uint settlementDays, Calendar calendar, double faceAmount, Date maturityDate, BusinessDayConvention paymentConvention, double redemption) : this(NQuantLibcPINVOKE.new_ZeroCouponBond__SWIG_1(settlementDays, Calendar.getCPtr(calendar), faceAmount, Date.getCPtr(maturityDate), (int)paymentConvention, redemption), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ZeroCouponBond(uint settlementDays, Calendar calendar, double faceAmount, Date maturityDate, BusinessDayConvention paymentConvention) : this(NQuantLibcPINVOKE.new_ZeroCouponBond__SWIG_2(settlementDays, Calendar.getCPtr(calendar), faceAmount, Date.getCPtr(maturityDate), (int)paymentConvention), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ZeroCouponBond(uint settlementDays, Calendar calendar, double faceAmount, Date maturityDate) : this(NQuantLibcPINVOKE.new_ZeroCouponBond__SWIG_3(settlementDays, Calendar.getCPtr(calendar), faceAmount, Date.getCPtr(maturityDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
