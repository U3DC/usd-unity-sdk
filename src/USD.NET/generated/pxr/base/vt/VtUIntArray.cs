//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class VtUIntArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtUIntArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtUIntArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtUIntArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtUIntArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtUIntArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public uint this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtUIntArray() : this(UsdCsPINVOKE.new_VtUIntArray__SWIG_0(), true) {
  }

  public VtUIntArray(VtUIntArray other) : this(UsdCsPINVOKE.new_VtUIntArray__SWIG_1(VtUIntArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtUIntArray(uint n, uint value) : this(UsdCsPINVOKE.new_VtUIntArray__SWIG_3(n, value), true) {
  }

  public VtUIntArray(uint n) : this(UsdCsPINVOKE.new_VtUIntArray__SWIG_4(n), true) {
  }

  public void push_back(uint elem) {
    UsdCsPINVOKE.VtUIntArray_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    UsdCsPINVOKE.VtUIntArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtUIntArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtUIntArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtUIntArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtUIntArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtUIntArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtUIntArray_clear(swigCPtr);
  }

  public void assign(uint n, uint fill) {
    UsdCsPINVOKE.VtUIntArray_assign(swigCPtr, n, fill);
  }

  public void swap(VtUIntArray other) {
    UsdCsPINVOKE.VtUIntArray_swap(swigCPtr, VtUIntArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtUIntArray other) {
    bool ret = UsdCsPINVOKE.VtUIntArray_IsIdentical(swigCPtr, VtUIntArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtUIntArray lhs, VtUIntArray rhs) {
    bool ret = UsdCsPINVOKE.VtUIntArray_Equals(VtUIntArray.getCPtr(lhs), VtUIntArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtUIntArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(uint[] dest) {
    UsdCsPINVOKE.VtUIntArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(uint[] src) {
    UsdCsPINVOKE.VtUIntArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtUIntArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtUIntArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected uint GetValue(int index) {
    uint ret = UsdCsPINVOKE.VtUIntArray_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, uint value) {
    UsdCsPINVOKE.VtUIntArray_SetValue(swigCPtr, index, value);
  }

}

}
