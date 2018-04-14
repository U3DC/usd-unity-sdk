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

public class UsdGeomXformable : UsdGeomImageable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomXformable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomXformable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomXformable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomXformable() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomXformable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomXformable(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomXformable__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomXformable() : this(UsdCsPINVOKE.new_UsdGeomXformable__SWIG_1(), true) {
  }

  public UsdGeomXformable(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomXformable__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomXformable_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomXformable_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomXformable Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomXformable ret = new UsdGeomXformable(UsdCsPINVOKE.UsdGeomXformable_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetXformOpOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomXformable_GetXformOpOrderAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateXformOpOrderAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateXformOpOrderAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateXformOpOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public class XformQuery : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal XformQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XformQuery obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~XformQuery() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            UsdCsPINVOKE.delete_UsdGeomXformable_XformQuery(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public XformQuery() : this(UsdCsPINVOKE.new_UsdGeomXformable_XformQuery__SWIG_0(), true) {
    }
  
    public XformQuery(UsdGeomXformable xformable) : this(UsdCsPINVOKE.new_UsdGeomXformable_XformQuery__SWIG_1(UsdGeomXformable.getCPtr(xformable)), true) {
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public bool GetLocalTransformation(GfMatrix4d transform, UsdTimeCode time) {
      bool ret = UsdCsPINVOKE.UsdGeomXformable_XformQuery_GetLocalTransformation(swigCPtr, GfMatrix4d.getCPtr(transform), UsdTimeCode.getCPtr(time));
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public bool GetResetXformStack() {
      bool ret = UsdCsPINVOKE.UsdGeomXformable_XformQuery_GetResetXformStack(swigCPtr);
      return ret;
    }
  
    public bool TransformMightBeTimeVarying() {
      bool ret = UsdCsPINVOKE.UsdGeomXformable_XformQuery_TransformMightBeTimeVarying(swigCPtr);
      return ret;
    }
  
    public bool GetTimeSamples(StdDoubleVector times) {
      bool ret = UsdCsPINVOKE.UsdGeomXformable_XformQuery_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
      return ret;
    }
  
    public bool IsAttributeIncludedInLocalTransform(TfToken attrName) {
      bool ret = UsdCsPINVOKE.UsdGeomXformable_XformQuery_IsAttributeIncludedInLocalTransform(swigCPtr, TfToken.getCPtr(attrName));
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddXformOp__SWIG_0(swigCPtr, (int)opType, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddXformOp__SWIG_1(swigCPtr, (int)opType, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddXformOp__SWIG_2(swigCPtr, (int)opType, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddXformOp__SWIG_3(swigCPtr, (int)opType), true);
    return ret;
  }

  public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddTranslateOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddScaleOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXYZOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateXZYOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYXZOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateYZXOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZXYOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddRotateZYXOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddOrientOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision, TfToken opSuffix) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision) {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_2(swigCPtr, (int)precision), true);
    return ret;
  }

  public UsdGeomXformOp AddTransformOp() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_3(swigCPtr), true);
    return ret;
  }

  public bool SetResetXformStack(bool resetXform) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_SetResetXformStack(swigCPtr, resetXform);
    return ret;
  }

  public bool GetResetXformStack() {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetResetXformStack(swigCPtr);
    return ret;
  }

  public bool SetXformOpOrder(UsdGeomXformOpVector orderedXformOps, bool resetXformStack) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_SetXformOpOrder__SWIG_0(swigCPtr, UsdGeomXformOpVector.getCPtr(orderedXformOps), resetXformStack);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetXformOpOrder(UsdGeomXformOpVector orderedXformOps) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_SetXformOpOrder__SWIG_1(swigCPtr, UsdGeomXformOpVector.getCPtr(orderedXformOps));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomXformOpVector GetOrderedXformOps(out bool resetsXformStack) {
    UsdGeomXformOpVector ret = new UsdGeomXformOpVector(UsdCsPINVOKE.UsdGeomXformable_GetOrderedXformOps(swigCPtr, out resetsXformStack), true);
    return ret;
  }

  public bool ClearXformOpOrder() {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_ClearXformOpOrder(swigCPtr);
    return ret;
  }

  public UsdGeomXformOp MakeMatrixXform() {
    UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformable_MakeMatrixXform(swigCPtr), true);
    return ret;
  }

  public bool TransformMightBeTimeVarying() {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_TransformMightBeTimeVarying__SWIG_0(swigCPtr);
    return ret;
  }

  public bool TransformMightBeTimeVarying(UsdGeomXformOpVector ops) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_TransformMightBeTimeVarying__SWIG_1(swigCPtr, UsdGeomXformOpVector.getCPtr(ops));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTimeSamples(StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetTimeSamples__SWIG_0(swigCPtr, StdDoubleVector.getCPtr(times));
    return ret;
  }

  public static bool GetTimeSamples(UsdGeomXformOpVector orderedXformOps, StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetTimeSamples__SWIG_1(UsdGeomXformOpVector.getCPtr(orderedXformOps), StdDoubleVector.getCPtr(times));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetTimeSamplesInInterval(UsdGeomXformOpVector orderedXformOps, GfInterval interval, StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetTimeSamplesInInterval(UsdGeomXformOpVector.getCPtr(orderedXformOps), GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack);
    return ret;
  }

  public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdGeomXformOpVector ops, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_2(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdGeomXformOpVector.getCPtr(ops), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdGeomXformOpVector ops) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_3(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdGeomXformOpVector.getCPtr(ops));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetLocalTransformation(GfMatrix4d transform, UsdGeomXformOpVector ops, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_4(GfMatrix4d.getCPtr(transform), UsdGeomXformOpVector.getCPtr(ops), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsTransformationAffectedByAttrNamed(TfToken attrName) {
    bool ret = UsdCsPINVOKE.UsdGeomXformable_IsTransformationAffectedByAttrNamed(TfToken.getCPtr(attrName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly bool IsConcrete = UsdCsPINVOKE.UsdGeomXformable_IsConcrete_get();
  public static readonly bool IsTyped = UsdCsPINVOKE.UsdGeomXformable_IsTyped_get();
}

}
