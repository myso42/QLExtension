//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class listsxp_struct : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal listsxp_struct(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(listsxp_struct obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~listsxp_struct() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_listsxp_struct(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SEXPREC carval {
    set {
      NQuantLibcPINVOKE.listsxp_struct_carval_set(swigCPtr, SEXPREC.getCPtr(value));
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NQuantLibcPINVOKE.listsxp_struct_carval_get(swigCPtr);
      SEXPREC ret = (cPtr == global::System.IntPtr.Zero) ? null : new SEXPREC(cPtr, false);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SEXPREC cdrval {
    set {
      NQuantLibcPINVOKE.listsxp_struct_cdrval_set(swigCPtr, SEXPREC.getCPtr(value));
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NQuantLibcPINVOKE.listsxp_struct_cdrval_get(swigCPtr);
      SEXPREC ret = (cPtr == global::System.IntPtr.Zero) ? null : new SEXPREC(cPtr, false);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SEXPREC tagval {
    set {
      NQuantLibcPINVOKE.listsxp_struct_tagval_set(swigCPtr, SEXPREC.getCPtr(value));
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NQuantLibcPINVOKE.listsxp_struct_tagval_get(swigCPtr);
      SEXPREC ret = (cPtr == global::System.IntPtr.Zero) ? null : new SEXPREC(cPtr, false);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public listsxp_struct() : this(NQuantLibcPINVOKE.new_listsxp_struct(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
