using System;

namespace Microsoft.LiveLabs.PE
{
    [Flags]
    public enum AssemblyFlags : uint
    {
        PublicKey = 0x1,
        SideBySideCompatible = 0x0,
        Reserved = 0x30,
        Retargetable = 0x100,
        EnableJITcompileTracking = 0x8000,
        DisableJITcompileOptimizer = 0x4000,

        All = PublicKey | Reserved | Retargetable | EnableJITcompileTracking | DisableJITcompileOptimizer
    }

    public enum AssemblyHashAlgorithm : uint
    {
        None = 0x0,
        Reserved_MD5 = 0x8003,
        SHA1 = 0x8004
    }

    [Flags]
    public enum CallingConventionFlags : byte
    {
        Default = 0x0,
        C = 0x1,
        StandardCall = 0x2,
        ThisCall = 0x3,
        FastCall = 0x4,
        VarArg = 0x5,
        ArgumentConvention = 0x7,
        Generic = 0x10,
        HasThis = 0x20,
        ExplicitThis = 0x40
    }

    public enum CorILExceptionClause : ushort
    {
        Exception = 0x0000, // A typed exception clause
        Filter = 0x0001, // An exception filter and handler clause
        Finally = 0x0002, // A finally clause
        Fault = 0x0004 // Fault clause (finally that is called on exception only)
    }

    [Flags]
    public enum CorILMethod : ushort
    {
        FatFormat = 0x3,
        TinyFormat = 0x2,
        MoreSects = 0x8,
        InitLocals = 0x10
    }

    [Flags]
    public enum CorILMethodSect : byte
    {
        EHTable = 0x1,
        OptILTable = 0x2,
        FatFormat = 0x40,
        MoreSects = 0x80,
    }

    public enum TypeSigTag : byte
    {
        END = 0x00, //Marks end of a list
        VOID = 0x01,
        BOOLEAN = 0x02,
        CHAR = 0x03,
        I1 = 0x04,
        U1 = 0x05,
        I2 = 0x06,
        U2 = 0x07,
        I4 = 0x08,
        U4 = 0x09,
        I8 = 0x0a,
        U8 = 0x0b,
        R4 = 0x0c,
        R8 = 0x0d,
        STRING = 0x0e,
        PTR = 0x0f, //Followed by type
        BYREF = 0x10, //Followed by type
        VALUETYPE = 0x11,// Followed by TypeDef or TypeRef token
        CLASS = 0x12,//Followed by TypeDef or TypeRef token
        VAR = 0x13,// Generic parameter in a generic type definition, represented as number
        ARRAY = 0x14, //type rank boundsCount bound1 … loCount lo1 …
        GENERICINST = 0x15,//Generic type instantiation. Followed by type typearg-count type-1 ... type-n
        TYPEDBYREF = 0x16,
        I = 0x18, //System.IntPtr
        U = 0x19, //System.UIntPtr
        FNPTR = 0x1b, // Followed by full method signature
        OBJECT = 0x1c, //System.Object
        SZARRAY = 0x1d, //Single-dim array with 0 lower bound
        MVAR = 0x1e,//Generic parameter in a generic method definition, represented as number
        CMOD_REQD = 0x1f,//Required modifier : followed by a TypeDef or TypeRef token
        CMOD_OPT = 0x20, // Optional modifier : followed by a TypeDef or TypeRef token
        INTERNAL = 0x21, // Implemented within the CLI
        MODIFIER = 0x40, // Or’d with following element types
        SENTINEL = 0x41,//Sentinel for vararg method signature
        PINNED = 0x45, //Denotes a local variable that points at a pinned object
        SYSTYPE_ARGUMENT = 0x50, // Indicates an argument of type System.Type.
        CUSTOM_ATTRIBUTE_BOXED_ARGUMENT = 0x51, // Used in custom attributes to specify a boxed object (§23.3).
        RESERVED = 0x52, // Reserved
        CUSTOM_ATTRIBUTE_FIELD = 0x53, // Used in custom attributes to indicate a FIELD (§22.10, 23.3).
        CUSTOM_ATTRIBUTE_PROPERTY = 0x54, //Used in custom attributes to indicate a PROPERTY (§22.10, 23.3).}
        CUSTOM_ATTRIBUTE_ENUM = 0x55, //Used in custom attributes to indicate a PROPERTY (§22.10, 23.3).}
    }

    [Flags]
    public enum EventAttributes : uint
    {
        SpecialName = 0x200, // Event is special.
        RTSpecialName = 0x400, //CLI provides 'special' behavior, depending upon the name of the event
    }

    [Flags]
    public enum FieldAttributes : ushort
    {
        FieldAccessMask = 0x0007, // These 3 bits contain one of the following values:
        CompilerControlled = 0x0000, //Member not referenceable
        Private = 0x0001, //Accessible only by the parent type
        FamANDAssem = 0x0002, //Accessible by sub-types only in this Assembly
        Assembly = 0x0003, //Accessibly by anyone in the Assembly
        Family = 0x0004, //Accessible only by type and sub-types
        FamORAssem = 0x0005, //Accessibly by sub-types anywhere, plus anyone in assembly
        Public = 0x0006, //Accessibly by anyone who has visibility to this scope field contract attributes
        Static = 0x0010, //Defined on type, else per instance
        InitOnly = 0x0020, //Field can only be initialized, not written to after init
        Literal = 0x0040, //Value is compile time constant
        NotSerialized = 0x0080, //Reserved (to indicate this field should not be serialized when type is remoted)
        SpecialName = 0x0200, //Field is special
        PInvokeImpl = 0x2000, //Implementation is forwarded through PInvoke.
        RTSpecialName = 0x0400, //CLI provides 'special' behavior, depending upon the name of the field
        HasFieldMarshal = 0x1000, //Field has marshalling information 
        HasDefault = 0x8000, //Field has default
        HasFieldRVA = 0x0100, //Field has RVA
    }

    [Flags]
    public enum FileAttributes : uint
    {
        ContainsMetadata = 0x0,
        ContainsNoMetadata = 0x1
    }

    [Flags]
    public enum GenericParamAttributes : ushort
    {
        VarianceMask = 0x0003, // These 2 bits contain one of the following values:
        None = 0x0000, // The generic parameter is non-variant and has no special constraints
        Covariant = 0x0001, //The generic parameter is covariant
        Contravariant = 0x0002, //The generic parameter is contravariant
        SpecialConstraintMask = 0x001C, //These 3 bits contain one of the following values:
        ReferenceTypeConstraint = 0x0004, //The generic parameter has the class special constraint
        NotNullableValueTypeConstraint = 0x0008, //The generic parameter has the valuetype special constraint
        DefaultConstructorConstraint = 0x0010, //The generic parameter has the .ctor special constrain
    }

    [Flags]
    public enum ImageFileFlags : ushort
    {
        RELOCS_STRIPPED = 0x0001, // Relocation information was stripped from the file. The file must be loaded at its preferred base address. If the base address is not available, the loader reports an error.
        EXECUTABLE_IMAGE = 0x0002, // The file is executable (there are no unresolved external references).
        LINE_NUMS_STRIPPED = 0x0004, // COFF line numbers were stripped from the file.
        LOCAL_SYMS_STRIPPED = 0x0008, // COFF symbol table entries were stripped from file.
        AGGRESIVE_WS_TRIM = 0x0010, // Aggressively trim the working set. This value is obsolete as of Windows 2000.
        LARGE_ADDRESS_AWARE = 0x0020, // The application can handle addresses larger than 2 GB.
        BYTES_REVERSED_LO = 0x0080, // The bytes of the word are reversed. This flag is obsolete.
        MACHINE_32_BIT = 0x0100, // The computer supports 32-bit words.
        DEBUG_STRIPPED = 0x0200, // Debugging information was removed and stored separately in another file.
        REMOVABLE_RUN_FROM_SWAP = 0x0400, // If the image is on removable media, copy it to and run it from the swap file.
        NET_RUN_FROM_SWAP = 0x0800, // If the image is on the network, copy it to and run it from the swap file.
        SYSTEM = 0x1000, // The image is a system file.
        DLL = 0x2000, // The image is a DLL file. While it is an executable file, it cannot be run directly.
        UP_SYSTEM_ONLY = 0x4000, // The file should be run only on a uniprocessor computer.
        BYTES_REVERSED_HI = 0x8000, // The bytes of the word are reversed. This flag is obsolete
    }

    public enum ImageRelocation : byte
    {
        IMAGE_REL_BASED_ABSOLUTE = 0,
        IMAGE_REL_BASED_HIGH = 1,
        IMAGE_REL_BASED_LOW = 2,
        IMAGE_REL_BASED_HIGHLOW = 3,
    }

    [Flags]
    public enum ImageSectionCharacteristics : uint
    {
        TYPE_NO_PAD = 0x00000008,  // Reserved.
        CNT_CODE = 0x00000020,  // Section contains code.
        CNT_INITIALIZED_DATA = 0x00000040,  // Section contains initialized data.
        CNT_UNINITIALIZED_DATA = 0x00000080,  // Section contains uninitialized data.

        LNK_OTHER = 0x00000100,  // Reserved.
        LNK_INFO = 0x00000200,  // Section contains comments or some other type of information.
        LNK_REMOVE = 0x00000800,  // Section contents will not become part of image.
        LNK_COMDAT = 0x00001000,  // Section contents comdat.
        NO_DEFER_SPEC_EXC = 0x00004000,  // Reset speculative exceptions handling bits in the TLB entries for this section.
        GPREL = 0x00008000,  // Section content can be accessed relative to GP
        MEM_FARDATA = 0x00008000,
        MEM_PURGEABLE = 0x00020000,
        MEM_16BIT = 0x00020000,
        MEM_LOCKED = 0x00040000,
        MEM_PRELOAD = 0x00080000,

        ALIGN_1BYTES = 0x00100000,  //
        ALIGN_2BYTES = 0x00200000,  //
        ALIGN_4BYTES = 0x00300000,  //
        ALIGN_8BYTES = 0x00400000,  //
        ALIGN_16BYTES = 0x00500000,  // Default alignment if no others are specified.
        ALIGN_32BYTES = 0x00600000,  //
        ALIGN_64BYTES = 0x00700000,  //
        ALIGN_128BYTES = 0x00800000,  //
        ALIGN_256BYTES = 0x00900000,  //
        ALIGN_512BYTES = 0x00A00000,  //
        ALIGN_1024BYTES = 0x00B00000,  //
        ALIGN_2048BYTES = 0x00C00000,  //
        ALIGN_4096BYTES = 0x00D00000,  //
        ALIGN_8192BYTES = 0x00E00000,  //
        ALIGN_MASK = 0x00F00000,

        LNK_NRELOC_OVFL = 0x01000000,  // Section contains extended relocations.
        MEM_DISCARDABLE = 0x02000000,  // Section can be discarded.
        MEM_NOT_CACHED = 0x04000000,  // Section is not cachable.
        MEM_NOT_PAGED = 0x08000000,  // Section is not pageable.
        MEM_SHARED = 0x10000000,  // Section is shareable.
        MEM_EXECUTE = 0x20000000,  // Section is executable.
        MEM_READ = 0x40000000,  // Section is readable.
        MEM_WRITE = 0x80000000,  // Section is writeable.
    }

    public enum ManifestResourceAttributes : uint
    {
        VisibilityMask = 0x0007, // These 3 bits contain one of the following values:
        Public = 0x0001, // The Resource is exported from the Assembly
        Private = 0x0002, //The Resource is private to the Assembly
    }

    [Flags]
    public enum MethodAttributes : ushort
    {
        MemberAccessMask = 0x0007, // These 3 bits contain one of the following values:
        CompilerControlled = 0x0000, // Member not referenceable
        Private = 0x0001, // Accessible only by the parent type
        FamANDAssem = 0x0002, // Accessible by sub-types only in this Assembly
        Assem = 0x0003, // Accessibly by anyone in the Assembly
        Family = 0x0004, // Accessible only by type and sub-types
        FamORAssem = 0x0005, // Accessibly by sub-types anywhere, plus anyone in assembly
        Public = 0x0006, // Accessibly by anyone who has visibility to this scope
        Static = 0x0010, // Defined on type, else per instance
        Final = 0x0020, // Method cannot be overridden
        Virtual = 0x0040, // Method is virtual
        HideBySig = 0x0080, // Method hides by name+sig, else just by name
        VtableLayoutMask = 0x0100, // Use this mask to retrieve vtable attributes. This bit contains one of the following values:
        ReuseSlot = 0x0000, // Method reuses existing slot in vtable
        NewSlot = 0x0100, // Method always gets a new slot in the vtable
        Strict = 0x0200, // Method can only be overriden if also accessible
        Abstract = 0x0400, // Method does not provide an implementation
        SpecialName = 0x0800, // Method is special Interop attributes
        PInvokeImpl = 0x2000, // Implementation is forwarded through PInvoke
        UnmanagedExport = 0x0008, // Reserved: shall be zero for conforming implementations Additional flags
        RTSpecialName = 0x1000, // CLI provides 'special' behavior, depending upon the name of the method
        HasSecurity = 0x4000, // Method has security associate with it
        RequireSecObject = 0x8000, // Method calls another method containing security code.
    }

    [Flags]
    public enum MethodImplAttributes : ushort
    {
        CodeTypeMask = 0x0003, // These 2 bits contain one of the following values:
        IL = 0x0000, // Method impl is CIL
        Native = 0x0001, // Method impl is native
        OPTIL = 0x0002, // Reserved: shall be zero in conforming implementations
        Runtime = 0x0003, // Method impl is provided by the runtime
        ManagedMask = 0x0004, // Flags specifying whether the code is managed or unmanaged. This bit contains one of the following values:
        Unmanaged = 0x0004, // Method impl is unmanaged, otherwise managed
        Managed = 0x0000, // Method impl is managed
        ForwardRef = 0x0010, // Indicates method is defined; used primarily in merge scenarios
        PreserveSig = 0x0080, // Reserved: conforming implementations can ignore
        InternalCall = 0x1000, // Reserved: shall be zero in conforming implementations
        Synchronized = 0x0020, // Method is single threaded through the body
        NoInlining = 0x0008, // Method cannot be inlined
        MaxMethodImplVal = 0xffff // Range check value
    }

    [Flags]
    public enum MethodSemanticsAttributes : ushort
    {
        Setter = 0x0001, // Setter for property
        Getter = 0x0002, // Getter for property
        Other = 0x0004, // Other method for property or event
        AddOn = 0x0008, // AddOn method for event
        RemoveOn = 0x0010, // RemoveOn method for event
        Fire = 0x0020, // Fire method for event
    }

    public enum OpCode : ushort
    {
        Nop = 0x00,
        Break = 0x01,
        Ldarg_0 = 0x02,
        Ldarg_1 = 0x03,
        Ldarg_2 = 0x04,
        Ldarg_3 = 0x05,
        Ldloc_0 = 0x06,
        Ldloc_1 = 0x07,
        Ldloc_2 = 0x08,
        Ldloc_3 = 0x09,
        Stloc_0 = 0x0A,
        Stloc_1 = 0x0B,
        Stloc_2 = 0x0C,
        Stloc_3 = 0x0D,
        Ldarg_s = 0x0E,
        Ldarga_s = 0x0F,
        Starg_s = 0x10,
        Ldloc_s = 0x11,
        Ldloca_s = 0x12,
        Stloc_s = 0x13,
        Ldnull = 0x14,
        Ldc_i4_m1 = 0x15,
        Ldc_i4_0 = 0x16,
        Ldc_i4_1 = 0x17,
        Ldc_i4_2 = 0x18,
        Ldc_i4_3 = 0x19,
        Ldc_i4_4 = 0x1A,
        Ldc_i4_5 = 0x1B,
        Ldc_i4_6 = 0x1C,
        Ldc_i4_7 = 0x1D,
        Ldc_i4_8 = 0x1E,
        Ldc_i4_s = 0x1F,
        Ldc_i4 = 0x20,
        Ldc_i8 = 0x21,
        Ldc_r4 = 0x22,
        Ldc_r8 = 0x23,
        Dup = 0x25,
        Pop = 0x26,
        Jmp = 0x27,
        Call = 0x28,
        Calli = 0x29,
        Ret = 0x2A,
        Br_s = 0x2B,
        Brfalse_s = 0x2C,
        Brtrue_s = 0x2D,
        Beq_s = 0x2E,
        Bge_s = 0x2F,
        Bgt_s = 0x30,
        Ble_s = 0x31,
        Blt_s = 0x32,
        Bne_un_s = 0x33,
        Bge_un_s = 0x34,
        Bgt_un_s = 0x35,
        Ble_un_s = 0x36,
        Blt_un_s = 0x37,
        Br = 0x38,
        Brfalse = 0x39,
        Brtrue = 0x3A,
        Beq = 0x3B,
        Bge = 0x3C,
        Bgt = 0x3D,
        Ble = 0x3E,
        Blt = 0x3F,
        Bne_un = 0x40,
        Bge_un = 0x41,
        Bgt_un = 0x42,
        Ble_un = 0x43,
        Blt_un = 0x44,
        Switch = 0x45,
        Ldind_i1 = 0x46,
        Ldind_u1 = 0x47,
        Ldind_i2 = 0x48,
        Ldind_u2 = 0x49,
        Ldind_i4 = 0x4A,
        Ldind_u4 = 0x4B,
        Ldind_i8 = 0x4C,
        Ldind_i = 0x4D,
        Ldind_r4 = 0x4E,
        Ldind_r8 = 0x4F,
        Ldind_ref = 0x50,
        Stind_ref = 0x51,
        Stind_i1 = 0x52,
        Stind_i2 = 0x53,
        Stind_i4 = 0x54,
        Stind_i8 = 0x55,
        Stind_r4 = 0x56,
        Stind_r8 = 0x57,
        Add = 0x58,
        Sub = 0x59,
        Mul = 0x5A,
        Div = 0x5B,
        Div_un = 0x5C,
        Rem = 0x5D,
        Rem_un = 0x5E,
        And = 0x5F,
        Or = 0x60,
        Xor = 0x61,
        Shl = 0x62,
        Shr = 0x63,
        Shr_un = 0x64,
        Neg = 0x65,
        Not = 0x66,
        Conv_i1 = 0x67,
        Conv_i2 = 0x68,
        Conv_i4 = 0x69,
        Conv_i8 = 0x6A,
        Conv_r4 = 0x6B,
        Conv_r8 = 0x6C,
        Conv_u4 = 0x6D,
        Conv_u8 = 0x6E,
        Callvirt = 0x6F,
        Cpobj = 0x70,
        Ldobj = 0x71,
        Ldstr = 0x72,
        Newobj = 0x73,
        Castclass = 0x74,
        Isinst = 0x75,
        Conv_r_un = 0x76,
        Unbox = 0x79,
        Throw = 0x7A,
        Ldfld = 0x7B,
        Ldflda = 0x7C,
        Stfld = 0x7D,
        Ldsfld = 0x7E,
        Ldsflda = 0x7F,
        Stsfld = 0x80,
        Stobj = 0x81,
        Conv_ovf_i1_un = 0x82,
        Conv_ovf_i2_un = 0x83,
        Conv_ovf_i4_un = 0x84,
        Conv_ovf_i8_un = 0x85,
        Conv_ovf_u1_un = 0x86,
        Conv_ovf_u2_un = 0x87,
        Conv_ovf_u4_un = 0x88,
        Conv_ovf_u8_un = 0x89,
        Conv_ovf_i_un = 0x8A,
        Conv_ovf_u_un = 0x8B,
        Box = 0x8C,
        Newarr = 0x8D,
        Ldlen = 0x8E,
        Ldelema = 0x8F,
        Ldelem_i1 = 0x90,
        Ldelem_u1 = 0x91,
        Ldelem_i2 = 0x92,
        Ldelem_u2 = 0x93,
        Ldelem_i4 = 0x94,
        Ldelem_u4 = 0x95,
        Ldelem_i8 = 0x96,
        Ldelem_i = 0x97,
        Ldelem_r4 = 0x98,
        Ldelem_r8 = 0x99,
        Ldelem_ref = 0x9A,
        Stelem_i = 0x9B,
        Stelem_i1 = 0x9C,
        Stelem_i2 = 0x9D,
        Stelem_i4 = 0x9E,
        Stelem_i8 = 0x9F,
        Stelem_r4 = 0xA0,
        Stelem_r8 = 0xA1,
        Stelem_ref = 0xA2,
        Ldelem = 0xA3,
        Stelem = 0xA4,
        Unbox_any = 0xA5,
        Conv_ovf_i1 = 0xB3,
        Conv_ovf_u1 = 0xB4,
        Conv_ovf_i2 = 0xB5,
        Conv_ovf_u2 = 0xB6,
        Conv_ovf_i4 = 0xB7,
        Conv_ovf_u4 = 0xB8,
        Conv_ovf_i8 = 0xB9,
        Conv_ovf_u8 = 0xBA,
        Refanyval = 0xC2,
        Ckfinite = 0xC3,
        Mkrefany = 0xC6,
        Ldtoken = 0xD0,
        Conv_u2 = 0xD1,
        Conv_u1 = 0xD2,
        Conv_i = 0xD3,
        Conv_ovf_i = 0xD4,
        Conv_ovf_u = 0xD5,
        Add_ovf = 0xD6,
        Add_ovf_un = 0xD7,
        Mul_ovf = 0xD8,
        Mul_ovf_un = 0xD9,
        Sub_ovf = 0xDA,
        Sub_ovf_un = 0xDB,
        Endfinally = 0xDC,
        Leave = 0xDD,
        Leave_s = 0xDE,
        Stind_i = 0xDF,
        Conv_u = 0xE0,
        Prefix7 = 0xF8,
        Prefix6 = 0xF9,
        Prefix5 = 0xFA,
        Prefix4 = 0xFB,
        Prefix3 = 0xFC,
        Prefix2 = 0xFD,
        Prefix1 = 0xFE,
        Prefixref = 0xFF,
        Arglist = 0xFE00,
        Ceq = 0xFE01,
        Cgt = 0xFE02,
        Cgt_un = 0xFE03,
        Clt = 0xFE04,
        Clt_un = 0xFE05,
        Ldftn = 0xFE06,
        Ldvirtftn = 0xFE07,
        Ldarg = 0xFE09,
        Ldarga = 0xFE0A,
        Starg = 0xFE0B,
        Ldloc = 0xFE0C,
        Ldloca = 0xFE0D,
        Stloc = 0xFE0E,
        Localloc = 0xFE0F,
        Endfilter = 0xFE11,
        Unaligned = 0xFE12,
        Volatile = 0xFE13,
        Tailcall = 0xFE14,
        Initobj = 0xFE15,
        Constrained = 0xFE16,
        Cpblk = 0xFE17,
        Initblk = 0xFE18,
        Rethrow = 0xFE1A,
        Sizeof = 0xFE1C,
        Refanytype = 0xFE1D,
        Readonly = 0xFE1E,
    }

    [Flags]
    public enum ParamAttributes : ushort
    {
        In = 0x0001, // Param is [In]
        Out = 0x0002, // Param is [out]
        Optional = 0x0010, // Param is optional
        HasDefault = 0x1000, // Param has default value
        HasFieldMarshal = 0x2000, // Param has FieldMarshal
        Unused = 0xcfe0, // Reserved: shall be zero in a conforming implementation
    }

    [Flags]
    public enum PInvokeAttributes : ushort
    {
        NoMangle = 0x0001, // PInvoke is to use the member name as specified Character set
        CharSetMask = 0x0006, // This is a resource file or other non-metadata-containing file. These 2 bits contain one of the following values:
        CharSetNotSpec = 0x0000,
        CharSetAnsi = 0x0002,
        CharSetUnicode = 0x0004,
        CharSetAuto = 0x0006,
        SupportsLastError = 0x0040, // Information about target function. Not relevant for fields Calling convention
        CallConvMask = 0x0700, // These 3 bits contain one of the following values:
        CallConvWinapi = 0x0100,
        CallConvCdecl = 0x0200,
        CallConvStdcall = 0x0300,
        CallConvThiscall = 0x0400,
        CallConvFastcall = 0x0500,
    }

    [Flags]
    public enum PropertyAttributes : ushort
    {
        SpecialName = 0x0200, // Property is special
        RTSpecialName = 0x0400, // Runtime(metadata internal APIs) should check name encoding
        HasDefault = 0x1000, // Property has default
        Unused = 0xe9ff, //Reserved: shall be zero in a conforming implementation 
    }

    [Flags]
    public enum RuntimeFlags : uint
    {
        ILONLY = 0x1,
        _32BITREQUIRED = 0x2,
        ILLIBRARY = 0x4,
        STRONGNAMESIGNED = 0x8,
        NATIVEENTRYPOINT = 0x10,
        TRACKDEBUGDATA = 0x10000,
    }

    [Flags]
    public enum MemberSigTag : byte
    {
        DEFAULT = 0x0,
        C = 0x1,
        STDCALL = 0x2,
        THISCALL = 0x3,
        FASTCALL = 0x4,
        VARARG = 0x5,
        FIELD = 0x6,
        LOCAL_SIG = 0x7,
        PROPERTY = 0x8,
        GENERICINST = 0x0A,
        MASK = 0xF,
        GENERIC = 0x10,
        HASTHIS = 0x20,
        EXPLICITTHIS = 0x40,
        SENTINEL = 0x41, // NOTE: Why is this here...?
    }

    public enum SubSystem : ushort
    {
        UNKNOWN = 0,   // Unknown subsystem.
        NATIVE = 1,   // Image doesn't require a subsystem.
        WINDOWS_GUI = 2,   // Image runs in the Windows GUI subsystem.
        WINDOWS_CUI = 3,   // Image runs in the Windows character subsystem.
        OS2_CUI = 5,   // image runs in the OS/2 character subsystem.
        POSIX_CUI = 7,   // image runs in the Posix character subsystem.
        NATIVE_WINDOWS = 8,   // image is a native Win9x driver.
        WINDOWS_CE_GUI = 9,   // Image runs in the Windows CE subsystem.
    }

    [Flags]
    public enum TypeAttributes : uint
    {
        VisibilityMask = 0x00000007, // Use this mask to retrieve visibility information. These 3 bits contain one of the following values:
        NotPublic = 0x00000000, // Class has no public scope
        Public = 0x00000001, // Class has public scope
        NestedPublic = 0x00000002, //  Class is nested with public visibility
        NestedPrivate = 0x00000003, //  Class is nested with private visibility
        NestedFamily = 0x00000004, //  Class is nested with family visibility
        NestedAssembly = 0x00000005, // Class is nested with assembly visibility
        NestedFamANDAssem = 0x00000006, // Class is nested with family and assembly visibility
        NestedFamORAssem = 0x00000007, // Class is nested with family or assembly visibility
        LayoutMask = 0x00000018, // Use this mask to retrieve class layout information. These 2 bits contain one of the following values:
        AutoLayout = 0x00000000, // Class fields are auto-laid out
        SequentialLayout = 0x00000008, // Class fields are laid out sequentially
        ExplicitLayout = 0x00000010, // Layout is supplied explicitly
        ClassSemanticsMask = 0x00000020, // Use this mask to retrive class semantics information. This bit contains one of the following values:
        Class = 0x00000000, // Type is a class
        Interface = 0x00000020, // Type is an interface
        Abstract = 0x00000080, // Class is abstract
        Sealed = 0x00000100, // Class cannot be extended
        SpecialName = 0x00000400, // Class name is special
        Import = 0x00001000, // Class/Interface is imported
        Serializable = 0x00002000, // Reserved (Class is serializable)
        StringFormatMask = 0x00030000, // Use this mask to retrieve string information for native interop. These 2 bits contain one of the following values:
        AnsiClass = 0x00000000, // LPSTR is interpreted as ANSI
        UnicodeClass = 0x00010000, // LPSTR is interpreted as Unicode
        AutoClass = 0x00020000, // LPSTR is interpreted automatically
        CustomFormatClass = 0x00030000, // A non-standard encoding specified by CustomStringFormatMask
        CustomStringFormatMask = 0x00C00000, // Use this mask to retrieve non-standard encoding information for native interop. The meaning of the values of these 2 bits is unspecified.
        BeforeFieldInit = 0x00100000, // Initialize the class before first static field access
        RTSpecialName = 0x00000800, // CLI provides 'special' behavior, depending upon the name of the Type 
        HasSecurity = 0x00040000, // Type has security associate with it
    }

    [Flags]
    public enum CorVtable : ushort
    {
        COR_VTABLE_32BIT = 0x01, // Vtable slots are 32 bits.
        COR_VTABLE_64BIT = 0x02, // Vtable slots are 64 bits.
        COR_VTABLE_FROM_UNMANAGED = 0x04, // Transition from unmanaged to managed code.
        COR_VTABLE_CALL_MOST_DERIVED = 0x10 // Call most derived method described by the token (only valid for virtual methods).
    }
    
    public enum TableTag : byte
    {
        Assembly = 0x20,
        AssemblyOS = 0x22,
        AssemblyProcessor = 0x21,
        AssemblyRef = 0x23,
        AssemblyRefOS = 0x25,
        AssemblyRefProcessor = 0x24,
        ClassLayout = 0x0F,
        Constant = 0x0B,
        CustomAttribute = 0x0C,
        DeclSecurity = 0x0E,
        EventMap = 0x12,
        Event = 0x14,
        ExportedType = 0x27,
        Field = 0x04,
        FieldLayout = 0x10,
        FieldMarshal = 0x0D,
        FieldRVA = 0x1D,
        File = 0x26,
        GenericParam = 0x2A,
        GenericParamConstraint = 0x2C,
        ImplMap = 0x1C,
        InterfaceImpl = 0x09,
        ManifestResource = 0x28,
        MemberRef = 0x0A,
        MethodDef = 0x06,
        MethodImpl = 0x19,
        MethodSemantics = 0x18,
        MethodSpec = 0x2B,
        Module = 0x00,
        ModuleRef = 0x1A,
        NestedClass = 0x29,
        Param = 0x08,
        Property = 0x17,
        PropertyMap = 0x15,
        StandAloneSig = 0x11,
        TypeDef = 0x02,
        TypeRef = 0x01,
        TypeSpec = 0x1B
    }
#if false
        Module = 0x00,
        TypeRef = 0x01,
        TypeDef = 0x02,
        Field = 0x04,
        MethodDef = 0x06,
        Param = 0x08,
        InterfaceImpl = 0x09,
        MemberRef = 0x0A,
        Constant = 0x0B,
        CustomAttribute = 0x0C,
        FieldMarshal = 0x0D,
        DeclSecurity = 0x0E,
        ClassLayout = 0x0F,
        FieldLayout = 0x10,
        StandAloneSig = 0x11,
        EventMap = 0x12,
        Event = 0x14,
        PropertyMap = 0x15,
        Property = 0x17,
        MethodSemantics = 0x18,
        MethodImpl = 0x19,
        ModuleRef = 0x1A,
        TypeSpec = 0x1B,
        ImplMap = 0x1C,
        FieldRVA = 0x1D,
        Assembly = 0x20,
        AssemblyProcessor = 0x21,
        AssemblyOS = 0x22,
        AssemblyRef = 0x23,
        AssemblyRefProcessor = 0x24,
        AssemblyRefOS = 0x25,
        File = 0x26,
        ExportedType = 0x27,
        ManifestResource = 0x28,
        NestedClass = 0x29,
        GenericParam = 0x2A,
        MethodSpec = 0x2B,
        GenericParamConstraint = 0x2C,
#endif
}
