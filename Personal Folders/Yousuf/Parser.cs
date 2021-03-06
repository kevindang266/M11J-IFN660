
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace M11J1
{
public enum Tokens {
    error=127,EOF=128,Number=129,Identifier=130,Abstract=131,Assert=132,
    Boolean=133,Break=134,Byte=135,Case=136,Catch=137,Char=138,
    Class=139,Const=140,Continue=141,Default=142,Do=143,Double=144,
    Else=145,Enum=146,Extends=147,Final=148,Finally=149,Float=150,
    For=151,Goto=152,If=153,Implements=154,Import=155,Instanceof=156,
    Int=157,Interface=158,Long=159,Native=160,New=161,Package=162,
    Private=163,Protected=164,Public=165,Return=166,Short=167,Static=168,
    Strictfp=169,Super=170,Switch=171,Synchronized=172,This=173,Throw=174,
    Throws=175,Transient=176,Try=177,Void=178,Volatile=179,While=180,
    BooleanLiteral=181,NullLiteral=182,IntegerLiteral=183,CharacterLiteral=184,StringLiteral=185,FloatingPointLiteral=186,
    VariableArguments=187,DoubleColon=188,Selection=189,Equal=190,GreaterOrEqual=191,LessOrEqual=192,
    NotEqual=193,AndCondition=194,OrCondition=195,Increment=196,Decrement=197,SignedLeftShift=198,
    SignedRightShift=199,UnsignedRightShift=200,AddAnd=201,SubtractAnd=202,MultiplyAnd=203,DivideAnd=204,
    BitwiseAnd=205,BitwiseInclusiveOr=206,BitwiseExclusiveOr=207,ModulusAnd=208,LeftShiftAnd=209,RightShiftAnd=210,
    ShiftRightZeroFill=211};

public struct ValueType
#line 4 "parser.y"
{
    public int num;
    public string name;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[118];
  private static State[] states = new State[151];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "PackageDeclaration_opt", "ImportDeclarations", 
      "TypeDeclarations", "ClassDeclaration", "NormalClassDeclaration", "ClassModifiers", 
      "TypeParameters_opt", "Superclass_opt", "Superinterfaces_opt", "ClassBody", 
      "ClassBodyDeclarations", "empty", "ClassBodyDeclaration", "ClassMemberDeclaration", 
      "MethodDeclaration", "MethodModifiers", "MethodHeader", "MethodBody", "Block", 
      "BlockStatements_opt", "BlockStatements", "BlockStatement", "LocalVariableDeclarationStatement", 
      "Statement", "LocalVariableDeclaration", "VariableModifiers", "UnannType", 
      "VariableDeclaratorList", "VariableModifier", "UnannPrimitiveType", "UnannReferenceType", 
      "NumericType", "IntegralType", "VariableDeclarator", "Comma_VariableDeclarator_opt", 
      "VariableDeclaratorId", "VariableInitializer", "StatementWithoutTrailingSubstatement", 
      "ExpressionStatement", "StatementExpression", "Assignment", "LeftHandSide", 
      "AssignmentOperator", "Expression", "ExpressionName", "AssignmentExpression", 
      "ConditionalExpression", "ConditionalOrExpression", "ConditionalAndExpression", 
      "InclusiveOrExpression", "ExclusiveOrExpression", "AndExpression", "EqualityExpression", 
      "RelationalExpression", "ShiftExpression", "AdditiveExpression", "MultiplicativeExpression", 
      "UnaryExpression", "UnaryExpressionNotPlusMinus", "PostfixExpression", 
      "Primary", "PrimaryNoNewArray", "Literal", "MethodModifier", "Result", 
      "MethodDeclarator", "Throws_opt", "FormalParameterList_opt", "Dims_opt", 
      "FormalParameterList", "LastFormalParameter", "FormalParameter", "UnannArrayType", 
      "UnannTypeVariable", "Dims", "Annotations", "Annotation", "ClassModifier", 
      "ImportDeclaration", "TypeDeclaration", };

  static Parser() {
    states[0] = new State(-117,new int[]{-1,1,-3,3,-14,150});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-111,new int[]{-4,4,-14,148,-81,149});
    states[4] = new State(new int[]{165,77,164,78,59,144,139,-111,128,-111},new int[]{-5,5,-81,145,-14,146,-82,147,-6,7,-7,8,-8,9,-80,76});
    states[5] = new State(new int[]{165,77,164,78,59,144,128,-2,139,-117},new int[]{-82,6,-6,7,-7,8,-8,9,-14,143,-80,76});
    states[6] = new State(-114);
    states[7] = new State(-115);
    states[8] = new State(-3);
    states[9] = new State(new int[]{139,10,165,77,164,78},new int[]{-80,142});
    states[10] = new State(new int[]{130,11});
    states[11] = new State(-117,new int[]{-9,12,-14,141});
    states[12] = new State(-117,new int[]{-10,13,-14,140});
    states[13] = new State(-117,new int[]{-11,14,-14,139});
    states[14] = new State(new int[]{123,16},new int[]{-12,15});
    states[15] = new State(-4);
    states[16] = new State(new int[]{165,132,168,133,59,136,125,-117,178,-117,157,-117,133,-117,130,-117},new int[]{-13,17,-14,137,-15,138,-16,20,-17,21,-18,22,-66,135});
    states[17] = new State(new int[]{125,18,165,132,168,133,59,136,178,-117,157,-117,133,-117,130,-117},new int[]{-15,19,-16,20,-17,21,-18,22,-14,134,-66,135});
    states[18] = new State(-5);
    states[19] = new State(-8);
    states[20] = new State(-9);
    states[21] = new State(-10);
    states[22] = new State(new int[]{178,130,157,65,133,66,130,71,165,132,168,133},new int[]{-19,23,-66,113,-67,114,-29,131,-32,62,-34,63,-35,64,-33,67,-75,68,-76,69});
    states[23] = new State(new int[]{123,26,59,112},new int[]{-20,24,-21,25});
    states[24] = new State(-12);
    states[25] = new State(-13);
    states[26] = new State(new int[]{148,72,165,77,164,78,130,109,125,-117,157,-117,133,-117,139,-117},new int[]{-22,27,-14,29,-23,30,-24,111,-25,32,-27,33,-28,35,-31,74,-6,75,-7,8,-8,9,-80,76,-26,79,-40,80,-41,81,-42,82,-43,84,-44,85,-47,108});
    states[27] = new State(new int[]{125,28});
    states[28] = new State(-15);
    states[29] = new State(new int[]{125,-16,157,-25,133,-25,130,-25,148,-25,139,-99,165,-99,164,-99});
    states[30] = new State(new int[]{148,72,165,77,164,78,130,109,125,-17,157,-117,133,-117,139,-117},new int[]{-24,31,-25,32,-27,33,-28,35,-14,73,-31,74,-6,75,-7,8,-8,9,-80,76,-26,79,-40,80,-41,81,-42,82,-43,84,-44,85,-47,108});
    states[31] = new State(-19);
    states[32] = new State(-20);
    states[33] = new State(new int[]{59,34});
    states[34] = new State(-23);
    states[35] = new State(new int[]{157,65,133,66,130,71,148,72},new int[]{-29,36,-31,61,-32,62,-34,63,-35,64,-33,67,-75,68,-76,69});
    states[36] = new State(new int[]{130,45},new int[]{-30,37,-36,38,-38,42});
    states[37] = new State(-24);
    states[38] = new State(new int[]{44,59,59,-117},new int[]{-37,39,-14,58});
    states[39] = new State(new int[]{44,40,59,-35});
    states[40] = new State(new int[]{130,45},new int[]{-36,41,-38,42});
    states[41] = new State(-38);
    states[42] = new State(new int[]{61,43,44,-39,59,-39});
    states[43] = new State(-41,new int[]{-39,44});
    states[44] = new State(-40);
    states[45] = new State(new int[]{61,-117,44,-117,59,-117,41,-117,91,-96},new int[]{-71,46,-14,47,-77,48,-78,55,-79,54});
    states[46] = new State(-88);
    states[47] = new State(new int[]{61,-89,44,-89,59,-89,41,-89,123,-89,91,-93});
    states[48] = new State(new int[]{61,-90,44,-90,59,-90,41,-90,123,-90,91,-96},new int[]{-78,49,-14,53,-79,54});
    states[49] = new State(new int[]{91,50},new int[]{-79,52});
    states[50] = new State(new int[]{93,51});
    states[51] = new State(-92);
    states[52] = new State(-95);
    states[53] = new State(-93);
    states[54] = new State(-94);
    states[55] = new State(new int[]{91,56},new int[]{-79,52});
    states[56] = new State(new int[]{93,57});
    states[57] = new State(-91);
    states[58] = new State(-36);
    states[59] = new State(new int[]{130,45},new int[]{-36,60,-38,42});
    states[60] = new State(-37);
    states[61] = new State(-27);
    states[62] = new State(-29);
    states[63] = new State(-31);
    states[64] = new State(-33);
    states[65] = new State(-34);
    states[66] = new State(-32);
    states[67] = new State(-30);
    states[68] = new State(-85);
    states[69] = new State(-96,new int[]{-77,70,-78,55,-14,53,-79,54});
    states[70] = new State(new int[]{130,-86,91,-96},new int[]{-78,49,-14,53,-79,54});
    states[71] = new State(-87);
    states[72] = new State(-28);
    states[73] = new State(new int[]{157,-25,133,-25,130,-25,148,-25,139,-99,165,-99,164,-99});
    states[74] = new State(-26);
    states[75] = new State(-21);
    states[76] = new State(-100);
    states[77] = new State(-102);
    states[78] = new State(-103);
    states[79] = new State(-22);
    states[80] = new State(-42);
    states[81] = new State(-43);
    states[82] = new State(new int[]{59,83});
    states[83] = new State(-44);
    states[84] = new State(-45);
    states[85] = new State(new int[]{61,110},new int[]{-45,86});
    states[86] = new State(new int[]{183,106,130,109,59,-49},new int[]{-46,87,-48,88,-49,89,-50,90,-51,91,-52,92,-53,93,-54,94,-55,95,-56,96,-57,97,-58,98,-59,99,-60,100,-61,101,-62,102,-63,103,-64,104,-65,105,-43,107,-44,85,-47,108});
    states[87] = new State(-46);
    states[88] = new State(-50);
    states[89] = new State(-51);
    states[90] = new State(-53);
    states[91] = new State(-54);
    states[92] = new State(-55);
    states[93] = new State(-56);
    states[94] = new State(-57);
    states[95] = new State(-58);
    states[96] = new State(-59);
    states[97] = new State(-60);
    states[98] = new State(-61);
    states[99] = new State(-62);
    states[100] = new State(-63);
    states[101] = new State(-64);
    states[102] = new State(-65);
    states[103] = new State(-66);
    states[104] = new State(-67);
    states[105] = new State(-68);
    states[106] = new State(-69);
    states[107] = new State(-52);
    states[108] = new State(-47);
    states[109] = new State(-70);
    states[110] = new State(-48);
    states[111] = new State(-18);
    states[112] = new State(-14);
    states[113] = new State(-73);
    states[114] = new State(new int[]{130,118},new int[]{-68,115});
    states[115] = new State(-97,new int[]{-69,116,-14,117});
    states[116] = new State(-76);
    states[117] = new State(-98);
    states[118] = new State(new int[]{40,119});
    states[119] = new State(new int[]{148,72,41,-117,157,-117,133,-117,130,-117},new int[]{-70,120,-14,123,-72,124,-73,125,-74,126,-28,127,-31,74});
    states[120] = new State(new int[]{41,121});
    states[121] = new State(new int[]{123,-117,59,-117,91,-96},new int[]{-71,122,-14,47,-77,48,-78,55,-79,54});
    states[122] = new State(-79);
    states[123] = new State(new int[]{41,-80,157,-25,133,-25,130,-25,148,-25});
    states[124] = new State(-81);
    states[125] = new State(-82);
    states[126] = new State(-83);
    states[127] = new State(new int[]{157,65,133,66,130,71,148,72},new int[]{-29,128,-31,61,-32,62,-34,63,-35,64,-33,67,-75,68,-76,69});
    states[128] = new State(new int[]{130,45},new int[]{-38,129});
    states[129] = new State(-84);
    states[130] = new State(-77);
    states[131] = new State(-78);
    states[132] = new State(-74);
    states[133] = new State(-75);
    states[134] = new State(-71);
    states[135] = new State(-72);
    states[136] = new State(-11);
    states[137] = new State(-6);
    states[138] = new State(-7);
    states[139] = new State(-105);
    states[140] = new State(-106);
    states[141] = new State(-104);
    states[142] = new State(-101);
    states[143] = new State(-99);
    states[144] = new State(-116);
    states[145] = new State(-110);
    states[146] = new State(new int[]{165,-99,164,-99,59,-112,139,-99,128,-112});
    states[147] = new State(-113);
    states[148] = new State(-108);
    states[149] = new State(-109);
    states[150] = new State(-107);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-3,-4,-5});
    rules[3] = new Rule(-6, new int[]{-7});
    rules[4] = new Rule(-7, new int[]{-8,139,130,-9,-10,-11,-12});
    rules[5] = new Rule(-12, new int[]{123,-13,125});
    rules[6] = new Rule(-13, new int[]{-14});
    rules[7] = new Rule(-13, new int[]{-15});
    rules[8] = new Rule(-13, new int[]{-13,-15});
    rules[9] = new Rule(-15, new int[]{-16});
    rules[10] = new Rule(-16, new int[]{-17});
    rules[11] = new Rule(-16, new int[]{59});
    rules[12] = new Rule(-17, new int[]{-18,-19,-20});
    rules[13] = new Rule(-20, new int[]{-21});
    rules[14] = new Rule(-20, new int[]{59});
    rules[15] = new Rule(-21, new int[]{123,-22,125});
    rules[16] = new Rule(-22, new int[]{-14});
    rules[17] = new Rule(-22, new int[]{-23});
    rules[18] = new Rule(-23, new int[]{-24});
    rules[19] = new Rule(-23, new int[]{-23,-24});
    rules[20] = new Rule(-24, new int[]{-25});
    rules[21] = new Rule(-24, new int[]{-6});
    rules[22] = new Rule(-24, new int[]{-26});
    rules[23] = new Rule(-25, new int[]{-27,59});
    rules[24] = new Rule(-27, new int[]{-28,-29,-30});
    rules[25] = new Rule(-28, new int[]{-14});
    rules[26] = new Rule(-28, new int[]{-31});
    rules[27] = new Rule(-28, new int[]{-28,-31});
    rules[28] = new Rule(-31, new int[]{148});
    rules[29] = new Rule(-29, new int[]{-32});
    rules[30] = new Rule(-29, new int[]{-33});
    rules[31] = new Rule(-32, new int[]{-34});
    rules[32] = new Rule(-32, new int[]{133});
    rules[33] = new Rule(-34, new int[]{-35});
    rules[34] = new Rule(-35, new int[]{157});
    rules[35] = new Rule(-30, new int[]{-36,-37});
    rules[36] = new Rule(-37, new int[]{-14});
    rules[37] = new Rule(-37, new int[]{44,-36});
    rules[38] = new Rule(-37, new int[]{-37,44,-36});
    rules[39] = new Rule(-36, new int[]{-38});
    rules[40] = new Rule(-36, new int[]{-38,61,-39});
    rules[41] = new Rule(-39, new int[]{});
    rules[42] = new Rule(-26, new int[]{-40});
    rules[43] = new Rule(-40, new int[]{-41});
    rules[44] = new Rule(-41, new int[]{-42,59});
    rules[45] = new Rule(-42, new int[]{-43});
    rules[46] = new Rule(-43, new int[]{-44,-45,-46});
    rules[47] = new Rule(-44, new int[]{-47});
    rules[48] = new Rule(-45, new int[]{61});
    rules[49] = new Rule(-46, new int[]{});
    rules[50] = new Rule(-46, new int[]{-48});
    rules[51] = new Rule(-48, new int[]{-49});
    rules[52] = new Rule(-48, new int[]{-43});
    rules[53] = new Rule(-49, new int[]{-50});
    rules[54] = new Rule(-50, new int[]{-51});
    rules[55] = new Rule(-51, new int[]{-52});
    rules[56] = new Rule(-52, new int[]{-53});
    rules[57] = new Rule(-53, new int[]{-54});
    rules[58] = new Rule(-54, new int[]{-55});
    rules[59] = new Rule(-55, new int[]{-56});
    rules[60] = new Rule(-56, new int[]{-57});
    rules[61] = new Rule(-57, new int[]{-58});
    rules[62] = new Rule(-58, new int[]{-59});
    rules[63] = new Rule(-59, new int[]{-60});
    rules[64] = new Rule(-60, new int[]{-61});
    rules[65] = new Rule(-61, new int[]{-62});
    rules[66] = new Rule(-62, new int[]{-63});
    rules[67] = new Rule(-63, new int[]{-64});
    rules[68] = new Rule(-64, new int[]{-65});
    rules[69] = new Rule(-65, new int[]{183});
    rules[70] = new Rule(-47, new int[]{130});
    rules[71] = new Rule(-18, new int[]{-14});
    rules[72] = new Rule(-18, new int[]{-66});
    rules[73] = new Rule(-18, new int[]{-18,-66});
    rules[74] = new Rule(-66, new int[]{165});
    rules[75] = new Rule(-66, new int[]{168});
    rules[76] = new Rule(-19, new int[]{-67,-68,-69});
    rules[77] = new Rule(-67, new int[]{178});
    rules[78] = new Rule(-67, new int[]{-29});
    rules[79] = new Rule(-68, new int[]{130,40,-70,41,-71});
    rules[80] = new Rule(-70, new int[]{-14});
    rules[81] = new Rule(-70, new int[]{-72});
    rules[82] = new Rule(-72, new int[]{-73});
    rules[83] = new Rule(-73, new int[]{-74});
    rules[84] = new Rule(-74, new int[]{-28,-29,-38});
    rules[85] = new Rule(-33, new int[]{-75});
    rules[86] = new Rule(-75, new int[]{-76,-77});
    rules[87] = new Rule(-76, new int[]{130});
    rules[88] = new Rule(-38, new int[]{130,-71});
    rules[89] = new Rule(-71, new int[]{-14});
    rules[90] = new Rule(-71, new int[]{-77});
    rules[91] = new Rule(-77, new int[]{-78,91,93});
    rules[92] = new Rule(-77, new int[]{-77,-78,91,93});
    rules[93] = new Rule(-78, new int[]{-14});
    rules[94] = new Rule(-78, new int[]{-79});
    rules[95] = new Rule(-78, new int[]{-78,-79});
    rules[96] = new Rule(-79, new int[]{});
    rules[97] = new Rule(-69, new int[]{});
    rules[98] = new Rule(-69, new int[]{-14});
    rules[99] = new Rule(-8, new int[]{-14});
    rules[100] = new Rule(-8, new int[]{-80});
    rules[101] = new Rule(-8, new int[]{-8,-80});
    rules[102] = new Rule(-80, new int[]{165});
    rules[103] = new Rule(-80, new int[]{164});
    rules[104] = new Rule(-9, new int[]{-14});
    rules[105] = new Rule(-11, new int[]{-14});
    rules[106] = new Rule(-10, new int[]{-14});
    rules[107] = new Rule(-3, new int[]{-14});
    rules[108] = new Rule(-4, new int[]{-14});
    rules[109] = new Rule(-4, new int[]{-81});
    rules[110] = new Rule(-4, new int[]{-4,-81});
    rules[111] = new Rule(-81, new int[]{});
    rules[112] = new Rule(-5, new int[]{-14});
    rules[113] = new Rule(-5, new int[]{-82});
    rules[114] = new Rule(-5, new int[]{-5,-82});
    rules[115] = new Rule(-82, new int[]{-6});
    rules[116] = new Rule(-82, new int[]{59});
    rules[117] = new Rule(-14, new int[]{});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 430 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}
