// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  LAPTOP-V2TTC46J
// DateTime: 27/05/2017 8:19:20 PM
// UserName: HSBaek
// Input file <parser.y - 27/05/2017 8:18:56 PM>

// options: lines diagnose & report gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace M11J1
{
public enum Tokens {
    error=127,EOF=128,IntegerLiteral=129,Identifier=130,FloatingPointLiteral=131,CharacterLiteral=132,
    Abstract=133,Assert=134,Boolean=135,Break=136,Byte=137,Case=138,
    Catch=139,Char=140,Class=141,Const=142,Continue=143,Default=144,
    Do=145,Double=146,Else=147,Enum=148,Extends=149,Final=150,
    Finally=151,Float=152,For=153,Goto=154,If=155,Implements=156,
    Import=157,InstanceOf=158,Int=159,Interface=160,Long=161,Native=162,
    New=163,Package=164,Private=165,Protected=166,Public=167,Return=168,
    Short=169,Static=170,Strictfp=171,Super=172,Switch=173,Synchronized=174,
    This=175,Throw=176,Throws=177,Transient=178,Try=179,Void=180,
    Volatile=181,While=182,BooleanLiteral=183,NullLiteral=184,StringLiteral=185,VariableArguments=186,
    DoubleColon=187,Selection=188,Equal=189,GreaterOrEqual=190,LessOrEqual=191,NotEqual=192,
    AndCondition=193,OrCondition=194,Increment=195,Decrement=196,SignedLeftShift=197,SignedRightShift=198,
    UnsignedRightShift=199,AddAnd=200,SubtractAnd=201,MultiplyAnd=202,DivideAnd=203,BitwiseAnd=204,
    BitwiseInclusiveOr=205,BitwiseExclusiveOr=206,ModulusAnd=207,LeftShiftAnd=208,RightShiftAnd=209,ShiftRightZeroFill=210,
    NoElse=211};

public struct ValueType
#line 8 "parser.y"
{
	public AST.CompilationUnit cu;
	public AST.ClassDeclaration cd;
	public AST.MethodHeader methodHeader;
	public AST.MethodDeclarator methodDeclarator;
	public AST.Modifier modifier;
	public AST.MethodDeclaration methodDeclaration;
	public AST.Parameter parameter;
	public List<AST.Modifier> modifiers;
	public List<AST.MethodDeclaration> methodDeclarations;
	public List<AST.Parameter> parameters;
	public List<AST.Statement> statements;
	public List<string> listString;
	public List<AST.VariableDeclaration> variableList;
	public AST.CompoundStatement compoundStatement;
	public AST.VariableDeclarationList variableDeclarationList;
	public AST.Type programType;
	public AST.VariableDeclaration variableDeclaration;
	public AST.Statement statement;
	public AST.Expression expression;

    public int num;
    public string name;
	public float fl;
	public char c;
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
  // Verbatim content from parser.y - 27/05/2017 8:18:56 PM
#line 4 "parser.y"
	public static AST.CompilationUnit Root;
#line default
  // End verbatim content from parser.y - 27/05/2017 8:18:56 PM

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[91];
  private static State[] states = new State[124];
  private static string[] nonTerms = new string[] {
      "ClassDeclaration", "NormalClassDeclaration", "Modifier", "Modifiers", 
      "MethodDeclaration", "ClassMemberDeclaration", "ClassBodyDeclaration", 
      "ClassBody", "ClassBodyDeclarations", "MethodHeader", "Result", "UnannType", 
      "UnannPrimitiveType", "UnannReferenceType", "NumericType", "UnannArrayType", 
      "UnannTypeVariable", "MethodDeclarator", "FormalParameterList", "FormalParameter", 
      "VariableDeclaratorId", "VariableDeclarator", "BlockStatements", "MethodBody", 
      "Block", "BlockStatement", "Statement", "SelectionStatement", "StatementWithoutTrailingSubstatement", 
      "ExpressionStatement", "StatementExpression", "VariableDeclaratorList", 
      "CommaVariableDeclarator_opt", "Assignment", "LeftHandSide", "Expression", 
      "AssignmentExpression", "Literal", "ExpressionName", "ConditionalExpression", 
      "ConditionalOrExpression", "ConditionalAndExpression", "InclusiveOrExpression", 
      "ExclusiveOrExpression", "AndExpression", "EqualityExpression", "RelationalExpression", 
      "ShiftExpression", "AdditiveExpression", "MultiplicativeExpression", "UnaryExpression", 
      "UnaryExpressionNotPlusMinus", "PostfixExpression", "Primary", "PrimaryNoNewArray", 
      "LocalVariableDeclaration", "LocalVariableDeclarationStatement", "AssignmentOperator", 
      "CompilationUnit", "$accept", "VariableModifiers", "VariableInitializer", 
      "Dims_opt", "Dims", };

  static Parser() {
    states[0] = new State(-26,new int[]{-59,1,-1,3,-2,4,-4,5});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(-3);
    states[5] = new State(new int[]{141,6,167,87,166,88,150,89,170,90},new int[]{-3,109});
    states[6] = new State(new int[]{130,7});
    states[7] = new State(new int[]{123,9},new int[]{-8,8});
    states[8] = new State(-4);
    states[9] = new State(-6,new int[]{-9,10});
    states[10] = new State(new int[]{125,11,59,123,180,-26,159,-26,135,-26,130,-26,167,-26,166,-26,150,-26,170,-26},new int[]{-7,12,-6,13,-5,14,-4,15});
    states[11] = new State(-5);
    states[12] = new State(-7);
    states[13] = new State(-8);
    states[14] = new State(-9);
    states[15] = new State(new int[]{180,121,159,75,135,76,130,86,167,87,166,88,150,89,170,90},new int[]{-10,16,-3,109,-11,110,-12,122,-13,73,-15,74,-14,77,-16,78,-17,79});
    states[16] = new State(new int[]{123,19,59,108},new int[]{-24,17,-25,18});
    states[17] = new State(-11);
    states[18] = new State(-13);
    states[19] = new State(-17,new int[]{-23,20});
    states[20] = new State(new int[]{125,21,159,75,135,76,130,81,167,87,166,88,150,89,170,90,123,19,155,101},new int[]{-26,22,-57,23,-56,24,-12,26,-13,73,-15,74,-14,77,-16,78,-17,79,-61,82,-3,91,-27,92,-29,93,-25,94,-30,95,-31,96,-34,98,-35,63,-39,99,-28,100});
    states[21] = new State(-15);
    states[22] = new State(-16);
    states[23] = new State(-18);
    states[24] = new State(new int[]{59,25});
    states[25] = new State(-20);
    states[26] = new State(new int[]{130,67},new int[]{-32,27,-22,28,-21,32});
    states[27] = new State(-21);
    states[28] = new State(-37,new int[]{-33,29});
    states[29] = new State(new int[]{44,30,59,-36});
    states[30] = new State(new int[]{130,67},new int[]{-22,31,-21,32});
    states[31] = new State(-38);
    states[32] = new State(new int[]{61,33,44,-39,59,-39});
    states[33] = new State(new int[]{129,56,130,58},new int[]{-62,34,-36,35,-37,36,-40,37,-41,38,-42,39,-43,40,-44,41,-45,42,-46,43,-47,44,-48,60,-49,47,-50,59,-51,50,-52,51,-53,52,-54,53,-55,54,-38,55,-39,61,-34,62,-35,63});
    states[34] = new State(-40);
    states[35] = new State(-41);
    states[36] = new State(-53);
    states[37] = new State(-73);
    states[38] = new State(-54);
    states[39] = new State(-55);
    states[40] = new State(-56);
    states[41] = new State(-57);
    states[42] = new State(-58);
    states[43] = new State(-59);
    states[44] = new State(new int[]{60,45,44,-60,59,-60,41,-60});
    states[45] = new State(new int[]{129,56,130,58},new int[]{-48,46,-49,47,-50,59,-51,50,-52,51,-53,52,-54,53,-55,54,-38,55,-39,57});
    states[46] = new State(-62);
    states[47] = new State(new int[]{43,48,60,-63,44,-63,59,-63,41,-63});
    states[48] = new State(new int[]{129,56,130,58},new int[]{-50,49,-51,50,-52,51,-53,52,-54,53,-55,54,-38,55,-39,57});
    states[49] = new State(-65);
    states[50] = new State(-66);
    states[51] = new State(-67);
    states[52] = new State(-68);
    states[53] = new State(-69);
    states[54] = new State(-71);
    states[55] = new State(-72);
    states[56] = new State(-75);
    states[57] = new State(-70);
    states[58] = new State(-76);
    states[59] = new State(-64);
    states[60] = new State(-61);
    states[61] = new State(new int[]{43,-70,60,-70,44,-70,59,-70,41,-70,61,-51});
    states[62] = new State(-74);
    states[63] = new State(new int[]{61,66},new int[]{-58,64});
    states[64] = new State(new int[]{129,56,130,58},new int[]{-36,65,-37,36,-40,37,-41,38,-42,39,-43,40,-44,41,-45,42,-46,43,-47,44,-48,60,-49,47,-50,59,-51,50,-52,51,-53,52,-54,53,-55,54,-38,55,-39,61,-34,62,-35,63});
    states[65] = new State(-50);
    states[66] = new State(-52);
    states[67] = new State(new int[]{91,70,61,-87,44,-87,59,-87,41,-87,159,-87,135,-87,130,-87,167,-87,166,-87,150,-87,170,-87},new int[]{-63,68,-64,69});
    states[68] = new State(-86);
    states[69] = new State(-88);
    states[70] = new State(new int[]{93,71});
    states[71] = new State(new int[]{91,70,61,-89,44,-89,59,-89,41,-89,159,-89,135,-89,130,-89,167,-89,166,-89,150,-89,170,-89,123,-89},new int[]{-64,72});
    states[72] = new State(-90);
    states[73] = new State(-31);
    states[74] = new State(-33);
    states[75] = new State(-35);
    states[76] = new State(-34);
    states[77] = new State(-32);
    states[78] = new State(-83);
    states[79] = new State(new int[]{91,70},new int[]{-64,80});
    states[80] = new State(-84);
    states[81] = new State(new int[]{91,-85,61,-76});
    states[82] = new State(new int[]{159,75,135,76,130,86,167,87,166,88,150,89,170,90},new int[]{-12,83,-3,85,-13,73,-15,74,-14,77,-16,78,-17,79});
    states[83] = new State(new int[]{130,67},new int[]{-32,84,-22,28,-21,32});
    states[84] = new State(-22);
    states[85] = new State(-24);
    states[86] = new State(-85);
    states[87] = new State(-27);
    states[88] = new State(-28);
    states[89] = new State(-29);
    states[90] = new State(-30);
    states[91] = new State(-23);
    states[92] = new State(-19);
    states[93] = new State(-42);
    states[94] = new State(-44);
    states[95] = new State(-45);
    states[96] = new State(new int[]{59,97});
    states[97] = new State(-46);
    states[98] = new State(-47);
    states[99] = new State(-51);
    states[100] = new State(-43);
    states[101] = new State(new int[]{40,102});
    states[102] = new State(new int[]{129,56,130,58},new int[]{-36,103,-37,36,-40,37,-41,38,-42,39,-43,40,-44,41,-45,42,-46,43,-47,44,-48,60,-49,47,-50,59,-51,50,-52,51,-53,52,-54,53,-55,54,-38,55,-39,61,-34,62,-35,63});
    states[103] = new State(new int[]{41,104});
    states[104] = new State(new int[]{123,19,130,58,155,101},new int[]{-27,105,-29,93,-25,94,-30,95,-31,96,-34,98,-35,63,-39,99,-28,100});
    states[105] = new State(new int[]{147,106,125,-48,159,-48,135,-48,130,-48,167,-48,166,-48,150,-48,170,-48,123,-48,155,-48});
    states[106] = new State(new int[]{123,19,130,58,155,101},new int[]{-27,107,-29,93,-25,94,-30,95,-31,96,-34,98,-35,63,-39,99,-28,100});
    states[107] = new State(-49);
    states[108] = new State(-14);
    states[109] = new State(-25);
    states[110] = new State(new int[]{130,112},new int[]{-18,111});
    states[111] = new State(-12);
    states[112] = new State(new int[]{40,113});
    states[113] = new State(-80,new int[]{-19,114});
    states[114] = new State(new int[]{41,115,159,-26,135,-26,130,-26,167,-26,166,-26,150,-26,170,-26},new int[]{-20,117,-4,118});
    states[115] = new State(new int[]{91,70,123,-87,59,-87},new int[]{-63,116,-64,69});
    states[116] = new State(-79);
    states[117] = new State(-81);
    states[118] = new State(new int[]{159,75,135,76,130,86,167,87,166,88,150,89,170,90},new int[]{-12,119,-3,109,-13,73,-15,74,-14,77,-16,78,-17,79});
    states[119] = new State(new int[]{130,67},new int[]{-21,120});
    states[120] = new State(-82);
    states[121] = new State(-77);
    states[122] = new State(-78);
    states[123] = new State(-10);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-60, new int[]{-59,128});
    rules[2] = new Rule(-59, new int[]{-1});
    rules[3] = new Rule(-1, new int[]{-2});
    rules[4] = new Rule(-2, new int[]{-4,141,130,-8});
    rules[5] = new Rule(-8, new int[]{123,-9,125});
    rules[6] = new Rule(-9, new int[]{});
    rules[7] = new Rule(-9, new int[]{-9,-7});
    rules[8] = new Rule(-7, new int[]{-6});
    rules[9] = new Rule(-6, new int[]{-5});
    rules[10] = new Rule(-6, new int[]{59});
    rules[11] = new Rule(-5, new int[]{-4,-10,-24});
    rules[12] = new Rule(-10, new int[]{-11,-18});
    rules[13] = new Rule(-24, new int[]{-25});
    rules[14] = new Rule(-24, new int[]{59});
    rules[15] = new Rule(-25, new int[]{123,-23,125});
    rules[16] = new Rule(-23, new int[]{-23,-26});
    rules[17] = new Rule(-23, new int[]{});
    rules[18] = new Rule(-26, new int[]{-57});
    rules[19] = new Rule(-26, new int[]{-27});
    rules[20] = new Rule(-57, new int[]{-56,59});
    rules[21] = new Rule(-56, new int[]{-12,-32});
    rules[22] = new Rule(-56, new int[]{-61,-12,-32});
    rules[23] = new Rule(-61, new int[]{-3});
    rules[24] = new Rule(-61, new int[]{-61,-3});
    rules[25] = new Rule(-4, new int[]{-4,-3});
    rules[26] = new Rule(-4, new int[]{});
    rules[27] = new Rule(-3, new int[]{167});
    rules[28] = new Rule(-3, new int[]{166});
    rules[29] = new Rule(-3, new int[]{150});
    rules[30] = new Rule(-3, new int[]{170});
    rules[31] = new Rule(-12, new int[]{-13});
    rules[32] = new Rule(-12, new int[]{-14});
    rules[33] = new Rule(-13, new int[]{-15});
    rules[34] = new Rule(-13, new int[]{135});
    rules[35] = new Rule(-15, new int[]{159});
    rules[36] = new Rule(-32, new int[]{-22,-33});
    rules[37] = new Rule(-33, new int[]{});
    rules[38] = new Rule(-33, new int[]{-33,44,-22});
    rules[39] = new Rule(-22, new int[]{-21});
    rules[40] = new Rule(-22, new int[]{-21,61,-62});
    rules[41] = new Rule(-62, new int[]{-36});
    rules[42] = new Rule(-27, new int[]{-29});
    rules[43] = new Rule(-27, new int[]{-28});
    rules[44] = new Rule(-29, new int[]{-25});
    rules[45] = new Rule(-29, new int[]{-30});
    rules[46] = new Rule(-30, new int[]{-31,59});
    rules[47] = new Rule(-31, new int[]{-34});
    rules[48] = new Rule(-28, new int[]{155,40,-36,41,-27});
    rules[49] = new Rule(-28, new int[]{155,40,-36,41,-27,147,-27});
    rules[50] = new Rule(-34, new int[]{-35,-58,-36});
    rules[51] = new Rule(-35, new int[]{-39});
    rules[52] = new Rule(-58, new int[]{61});
    rules[53] = new Rule(-36, new int[]{-37});
    rules[54] = new Rule(-40, new int[]{-41});
    rules[55] = new Rule(-41, new int[]{-42});
    rules[56] = new Rule(-42, new int[]{-43});
    rules[57] = new Rule(-43, new int[]{-44});
    rules[58] = new Rule(-44, new int[]{-45});
    rules[59] = new Rule(-45, new int[]{-46});
    rules[60] = new Rule(-46, new int[]{-47});
    rules[61] = new Rule(-47, new int[]{-48});
    rules[62] = new Rule(-47, new int[]{-47,60,-48});
    rules[63] = new Rule(-48, new int[]{-49});
    rules[64] = new Rule(-49, new int[]{-50});
    rules[65] = new Rule(-49, new int[]{-49,43,-50});
    rules[66] = new Rule(-50, new int[]{-51});
    rules[67] = new Rule(-51, new int[]{-52});
    rules[68] = new Rule(-52, new int[]{-53});
    rules[69] = new Rule(-53, new int[]{-54});
    rules[70] = new Rule(-53, new int[]{-39});
    rules[71] = new Rule(-54, new int[]{-55});
    rules[72] = new Rule(-55, new int[]{-38});
    rules[73] = new Rule(-37, new int[]{-40});
    rules[74] = new Rule(-37, new int[]{-34});
    rules[75] = new Rule(-38, new int[]{129});
    rules[76] = new Rule(-39, new int[]{130});
    rules[77] = new Rule(-11, new int[]{180});
    rules[78] = new Rule(-11, new int[]{-12});
    rules[79] = new Rule(-18, new int[]{130,40,-19,41,-63});
    rules[80] = new Rule(-19, new int[]{});
    rules[81] = new Rule(-19, new int[]{-19,-20});
    rules[82] = new Rule(-20, new int[]{-4,-12,-21});
    rules[83] = new Rule(-14, new int[]{-16});
    rules[84] = new Rule(-16, new int[]{-17,-64});
    rules[85] = new Rule(-17, new int[]{130});
    rules[86] = new Rule(-21, new int[]{130,-63});
    rules[87] = new Rule(-63, new int[]{});
    rules[88] = new Rule(-63, new int[]{-64});
    rules[89] = new Rule(-64, new int[]{91,93});
    rules[90] = new Rule(-64, new int[]{91,93,-64});
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
      case 2: // CompilationUnit -> ClassDeclaration
#line 83 "parser.y"
                             { Root = ValueStack[ValueStack.Depth-1].cu; }
#line default
        break;
      case 3: // ClassDeclaration -> NormalClassDeclaration
#line 87 "parser.y"
                                 { CurrentSemanticValue.cu = new AST.CompilationUnit(ValueStack[ValueStack.Depth-1].cd); }
#line default
        break;
      case 4: // NormalClassDeclaration -> Modifiers, Class, Identifier, ClassBody
#line 91 "parser.y"
                                            { CurrentSemanticValue.cd = new AST.ClassDeclaration(ValueStack[ValueStack.Depth-4].modifiers, ValueStack[ValueStack.Depth-2].name, ValueStack[ValueStack.Depth-1].methodDeclarations); }
#line default
        break;
      case 5: // ClassBody -> '{', ClassBodyDeclarations, '}'
#line 95 "parser.y"
                                       { CurrentSemanticValue.methodDeclarations = ValueStack[ValueStack.Depth-2].methodDeclarations; }
#line default
        break;
      case 6: // ClassBodyDeclarations -> /* empty */
#line 99 "parser.y"
                         { CurrentSemanticValue.methodDeclarations = new List<AST.MethodDeclaration>(); }
#line default
        break;
      case 7: // ClassBodyDeclarations -> ClassBodyDeclarations, ClassBodyDeclaration
#line 100 "parser.y"
                                                { CurrentSemanticValue.methodDeclarations = ValueStack[ValueStack.Depth-2].methodDeclarations; CurrentSemanticValue.methodDeclarations.Add(ValueStack[ValueStack.Depth-1].methodDeclaration); }
#line default
        break;
      case 8: // ClassBodyDeclaration -> ClassMemberDeclaration
#line 104 "parser.y"
                                 { CurrentSemanticValue.methodDeclaration = ValueStack[ValueStack.Depth-1].methodDeclaration; }
#line default
        break;
      case 9: // ClassMemberDeclaration -> MethodDeclaration
#line 108 "parser.y"
                              { CurrentSemanticValue.methodDeclaration = ValueStack[ValueStack.Depth-1].methodDeclaration; }
#line default
        break;
      case 11: // MethodDeclaration -> Modifiers, MethodHeader, MethodBody
#line 113 "parser.y"
                                          { CurrentSemanticValue.methodDeclaration = new AST.MethodDeclaration(ValueStack[ValueStack.Depth-3].modifiers, ValueStack[ValueStack.Depth-2].methodHeader, ValueStack[ValueStack.Depth-1].compoundStatement); }
#line default
        break;
      case 12: // MethodHeader -> Result, MethodDeclarator
#line 117 "parser.y"
                                  { CurrentSemanticValue.methodHeader = new AST.MethodHeader(ValueStack[ValueStack.Depth-2].programType, ValueStack[ValueStack.Depth-1].methodDeclarator); }
#line default
        break;
      case 13: // MethodBody -> Block
#line 121 "parser.y"
                     { CurrentSemanticValue.compoundStatement = ValueStack[ValueStack.Depth-1].compoundStatement; }
#line default
        break;
      case 15: // Block -> '{', BlockStatements, '}'
#line 126 "parser.y"
                                  { CurrentSemanticValue.compoundStatement = new AST.CompoundStatement(ValueStack[ValueStack.Depth-2].statements); }
#line default
        break;
      case 16: // BlockStatements -> BlockStatements, BlockStatement
#line 130 "parser.y"
                                        { CurrentSemanticValue.statements = ValueStack[ValueStack.Depth-2].statements; CurrentSemanticValue.statements.Add(ValueStack[ValueStack.Depth-1].statement); }
#line default
        break;
      case 17: // BlockStatements -> /* empty */
#line 131 "parser.y"
                         { CurrentSemanticValue.statements = new List<AST.Statement>(); }
#line default
        break;
      case 18: // BlockStatement -> LocalVariableDeclarationStatement
#line 135 "parser.y"
                                          { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].variableDeclarationList; }
#line default
        break;
      case 19: // BlockStatement -> Statement
#line 136 "parser.y"
                        { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 20: // LocalVariableDeclarationStatement -> LocalVariableDeclaration, ';'
#line 140 "parser.y"
                                      { CurrentSemanticValue.variableDeclarationList = new AST.VariableDeclarationList(ValueStack[ValueStack.Depth-2].variableList); }
#line default
        break;
      case 21: // LocalVariableDeclaration -> UnannType, VariableDeclaratorList
#line 144 "parser.y"
                                         { 
																CurrentSemanticValue.variableList = new List<AST.VariableDeclaration>();
																foreach(var variableName in ValueStack[ValueStack.Depth-1].listString)
																{
																	CurrentSemanticValue.variableList.Add(new AST.VariableDeclaration(ValueStack[ValueStack.Depth-2].programType, variableName));
																}
															}
#line default
        break;
      case 25: // Modifiers -> Modifiers, Modifier
#line 160 "parser.y"
                               { CurrentSemanticValue.modifiers = ValueStack[ValueStack.Depth-2].modifiers; CurrentSemanticValue.modifiers.Add(ValueStack[ValueStack.Depth-1].modifier); }
#line default
        break;
      case 26: // Modifiers -> /* empty */
#line 161 "parser.y"
                         { CurrentSemanticValue.modifiers = new List<AST.Modifier>(); }
#line default
        break;
      case 27: // Modifier -> Public
#line 165 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Public; }
#line default
        break;
      case 28: // Modifier -> Protected
#line 166 "parser.y"
                        { CurrentSemanticValue.modifier = AST.Modifier.Protected; }
#line default
        break;
      case 29: // Modifier -> Final
#line 167 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Final; }
#line default
        break;
      case 30: // Modifier -> Static
#line 168 "parser.y"
                     { CurrentSemanticValue.modifier = AST.Modifier.Static; }
#line default
        break;
      case 31: // UnannType -> UnannPrimitiveType
#line 172 "parser.y"
                              { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 32: // UnannType -> UnannReferenceType
#line 173 "parser.y"
                              { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 33: // UnannPrimitiveType -> NumericType
#line 177 "parser.y"
                         { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 35: // NumericType -> Int
#line 182 "parser.y"
                   { CurrentSemanticValue.programType = new AST.IntType(); }
#line default
        break;
      case 36: // VariableDeclaratorList -> VariableDeclarator, CommaVariableDeclarator_opt
#line 186 "parser.y"
                                                   { 
																CurrentSemanticValue.listString = new List<string>();
																CurrentSemanticValue.listString.Add(ValueStack[ValueStack.Depth-2].name);
																foreach(var variable in ValueStack[ValueStack.Depth-1].listString)
																{
																	CurrentSemanticValue.listString.Add(variable);
																}
															}
#line default
        break;
      case 37: // CommaVariableDeclarator_opt -> /* empty */
#line 197 "parser.y"
                         { CurrentSemanticValue.listString = new List<string>(); }
#line default
        break;
      case 38: // CommaVariableDeclarator_opt -> CommaVariableDeclarator_opt, ',', 
               //                                VariableDeclarator
#line 198 "parser.y"
                                                       { CurrentSemanticValue.listString = ValueStack[ValueStack.Depth-3].listString; CurrentSemanticValue.listString.Add(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 39: // VariableDeclarator -> VariableDeclaratorId
#line 202 "parser.y"
                                { CurrentSemanticValue.name = ValueStack[ValueStack.Depth-1].name; }
#line default
        break;
      case 42: // Statement -> StatementWithoutTrailingSubstatement
#line 211 "parser.y"
                                            { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 43: // Statement -> SelectionStatement
#line 212 "parser.y"
                              { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 44: // StatementWithoutTrailingSubstatement -> Block
#line 216 "parser.y"
                     { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].compoundStatement; }
#line default
        break;
      case 45: // StatementWithoutTrailingSubstatement -> ExpressionStatement
#line 217 "parser.y"
                               { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-1].statement; }
#line default
        break;
      case 46: // ExpressionStatement -> StatementExpression, ';'
#line 221 "parser.y"
                                  { CurrentSemanticValue.statement = ValueStack[ValueStack.Depth-2].statement; }
#line default
        break;
      case 47: // StatementExpression -> Assignment
#line 225 "parser.y"
                        { CurrentSemanticValue.statement = new AST.ExpressionStatement(ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 49: // SelectionStatement -> If, '(', Expression, ')', Statement, Else, Statement
#line 230 "parser.y"
                                                   { CurrentSemanticValue.statement = new AST.IfThenElseStatement(ValueStack[ValueStack.Depth-5].expression, ValueStack[ValueStack.Depth-3].statement, ValueStack[ValueStack.Depth-1].statement); }
#line default
        break;
      case 50: // Assignment -> LeftHandSide, AssignmentOperator, Expression
#line 238 "parser.y"
                                                { CurrentSemanticValue.expression = new AST.AssignmentExpression(ValueStack[ValueStack.Depth-3].expression, ValueStack[ValueStack.Depth-2].c, ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 51: // LeftHandSide -> ExpressionName
#line 242 "parser.y"
                           { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 52: // AssignmentOperator -> '='
#line 246 "parser.y"
                   { CurrentSemanticValue.c = '='; }
#line default
        break;
      case 53: // Expression -> AssignmentExpression
#line 251 "parser.y"
                                { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 54: // ConditionalExpression -> ConditionalOrExpression
#line 255 "parser.y"
                                  { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 55: // ConditionalOrExpression -> ConditionalAndExpression
#line 259 "parser.y"
                                   { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 56: // ConditionalAndExpression -> InclusiveOrExpression
#line 263 "parser.y"
                                 { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 57: // InclusiveOrExpression -> ExclusiveOrExpression
#line 267 "parser.y"
                                 { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 58: // ExclusiveOrExpression -> AndExpression
#line 271 "parser.y"
                           { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 59: // AndExpression -> EqualityExpression
#line 275 "parser.y"
                              { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 60: // EqualityExpression -> RelationalExpression
#line 279 "parser.y"
                                { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 61: // RelationalExpression -> ShiftExpression
#line 283 "parser.y"
                            { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 62: // RelationalExpression -> RelationalExpression, '<', ShiftExpression
#line 284 "parser.y"
                                               { CurrentSemanticValue.expression = new AST.BinaryExpression(ValueStack[ValueStack.Depth-3].expression,'<',ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 63: // ShiftExpression -> AdditiveExpression
#line 288 "parser.y"
                              { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 64: // AdditiveExpression -> MultiplicativeExpression
#line 292 "parser.y"
                                   { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 65: // AdditiveExpression -> AdditiveExpression, '+', MultiplicativeExpression
#line 293 "parser.y"
                                                    { CurrentSemanticValue.expression = new AST.BinaryExpression(ValueStack[ValueStack.Depth-3].expression,'+',ValueStack[ValueStack.Depth-1].expression); }
#line default
        break;
      case 66: // MultiplicativeExpression -> UnaryExpression
#line 297 "parser.y"
                            { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 67: // UnaryExpression -> UnaryExpressionNotPlusMinus
#line 301 "parser.y"
                                     { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 68: // UnaryExpressionNotPlusMinus -> PostfixExpression
#line 305 "parser.y"
                              { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 69: // PostfixExpression -> Primary
#line 309 "parser.y"
                      { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 70: // PostfixExpression -> ExpressionName
#line 310 "parser.y"
                           { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 71: // Primary -> PrimaryNoNewArray
#line 314 "parser.y"
                              { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 72: // PrimaryNoNewArray -> Literal
#line 318 "parser.y"
                      { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 73: // AssignmentExpression -> ConditionalExpression
#line 322 "parser.y"
                                 { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 74: // AssignmentExpression -> Assignment
#line 323 "parser.y"
                        { CurrentSemanticValue.expression = ValueStack[ValueStack.Depth-1].expression; }
#line default
        break;
      case 75: // Literal -> IntegerLiteral
#line 327 "parser.y"
                           { CurrentSemanticValue.expression = new AST.NumberExpression(ValueStack[ValueStack.Depth-1].num); }
#line default
        break;
      case 76: // ExpressionName -> Identifier
#line 331 "parser.y"
                        { CurrentSemanticValue.expression = new AST.IdentifierExpression(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 77: // Result -> Void
#line 335 "parser.y"
                    { CurrentSemanticValue.programType = new AST.VoidType(); }
#line default
        break;
      case 79: // MethodDeclarator -> Identifier, '(', FormalParameterList, ')', Dims_opt
#line 340 "parser.y"
                                                    { CurrentSemanticValue.methodDeclarator = new AST.MethodDeclarator(ValueStack[ValueStack.Depth-5].name, ValueStack[ValueStack.Depth-3].parameters); }
#line default
        break;
      case 80: // FormalParameterList -> /* empty */
#line 344 "parser.y"
                         { CurrentSemanticValue.parameters = new List<AST.Parameter>(); }
#line default
        break;
      case 81: // FormalParameterList -> FormalParameterList, FormalParameter
#line 345 "parser.y"
                                            { CurrentSemanticValue.parameters = ValueStack[ValueStack.Depth-2].parameters; CurrentSemanticValue.parameters.Add(ValueStack[ValueStack.Depth-1].parameter); }
#line default
        break;
      case 82: // FormalParameter -> Modifiers, UnannType, VariableDeclaratorId
#line 349 "parser.y"
                                               { CurrentSemanticValue.parameter = new AST.FormalParameter(ValueStack[ValueStack.Depth-3].modifiers, ValueStack[ValueStack.Depth-2].programType, ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 83: // UnannReferenceType -> UnannArrayType
#line 353 "parser.y"
                           { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-1].programType; }
#line default
        break;
      case 84: // UnannArrayType -> UnannTypeVariable, Dims
#line 357 "parser.y"
                                 { CurrentSemanticValue.programType = ValueStack[ValueStack.Depth-2].programType; }
#line default
        break;
      case 85: // UnannTypeVariable -> Identifier
#line 361 "parser.y"
                        { CurrentSemanticValue.programType = new AST.IdentifierType(); }
#line default
        break;
      case 86: // VariableDeclaratorId -> Identifier, Dims_opt
#line 365 "parser.y"
                               { CurrentSemanticValue.name = ValueStack[ValueStack.Depth-2].name; }
#line default
        break;
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

#line 379 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}
