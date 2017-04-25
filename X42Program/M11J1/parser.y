﻿%namespace M11J1

%{
	public static AST.CompilationUnit Root;
%}

%union
{
	public AST.CompilationUnit cu;
	public AST.ClassDeclaration cd;
	public AST.MethodHeader methodHeader;
	public AST.MethodDeclarator methodDeclarator;
	public AST.Modifier modifier;
	public AST.MethodDeclaration methodDeclaration;
	public AST.Parameter parameter;
	public System.Collections.Generic.List<AST.Modifier> modifiers;
	public System.Collections.Generic.List<AST.MethodDeclaration> methodDeclarations;
	public System.Collections.Generic.List<AST.Parameter> parameters;
	public AST.Type programType;
	public AST.VariableDeclaration variableDeclaration;

    public int num;
    public string name;
}

%token <num> Int
%token <name> Identifier
%token	Abstract Assert Boolean Break Byte Case Catch Char Class Const Continue Default Do Double Else
		Enum Extends Final Finally Float For Goto If Implements Import InstanceOf Int Interface Long Native
		New Package Private Protected Public Return Short Static Strictfp Super Switch Synchronized This
		Throw Throws Transient Try Void Volatile While BooleanLiteral NullLiteral
		IntegerLiteral CharacterLiteral StringLiteral FloatingPointLiteral VariableArguments
		DoubleColon Selection Equal GreaterOrEqual LessOrEqual NotEqual AndCondition OrCondition Increment Decrement
		SignedLeftShift SignedRightShift UnsignedRightShift AddAnd SubtractAnd MultiplyAnd DivideAnd BitwiseAnd
		BitwiseInclusiveOr BitwiseExclusiveOr ModulusAnd LeftShiftAnd RightShiftAnd ShiftRightZeroFill

%type <cu> ClassDeclaration
%type <cd> NormalClassDeclaration
%type <modifier> Modifier
%type <modifiers> Modifiers
%type <methodDeclaration> MethodDeclaration, ClassMemberDeclaration, ClassBodyDeclaration
%type <methodDeclarations> ClassBody, ClassBodyDeclarations
%type <methodHeader> MethodHeader
%type <programType> Result, UnannType, UnannPrimitiveType, UnannReferenceType, NumericType, UnannArrayType
%type <methodDeclarator> MethodDeclarator
%type <parameters> FormalParameterList
%type <parameter> FormalParameter
%type <name> UnannTypeVariable
%type <variableDeclaration> VariableDeclaratorId, VariableDeclarator
		
%left '='
%nonassoc '<'
%left '+' '-'
%left '*' '/'

%%

CompilationUnit
	: ClassDeclaration										{ Root = $1; }
	;

ClassDeclaration
	: NormalClassDeclaration								{ $$ = new AST.CompilationUnit($1); }
	;

NormalClassDeclaration
	: Modifiers Class Identifier ClassBody					{ $$ = new AST.ClassDeclaration($1, $3, $4); }
	;

ClassBody
	: '{' ClassBodyDeclarations '}'							{ $$ = $2; }
	;

ClassBodyDeclarations	
	: /* empty */											{ $$ = new System.Collections.Generic.List<AST.MethodDeclaration>(); }
	| ClassBodyDeclaration ClassBodyDeclarations			{ $$ = $2; $$.Add($1); }
	;

ClassBodyDeclaration										
	: ClassMemberDeclaration								{ $$ = $1; }
	;

ClassMemberDeclaration
	: MethodDeclaration										{ $$ = $1; }
	| ';'
	;

MethodDeclaration
	: Modifiers MethodHeader MethodBody						{ $$ = new AST.MethodDeclaration($1, $2); }
	;

MethodHeader
	: Result MethodDeclarator								{ $$ = new AST.MethodHeader($1, $2); }
	;

MethodBody
	: Block
	| ';'
	;

Block
	: '{' BlockStatements_opt '}'
	;

BlockStatements_opt
	: /* empty */
	| BlockStatements 
	;

BlockStatements
	: BlockStatement
	| BlockStatements BlockStatement
	;

BlockStatement
	: LocalVariableDeclarationStatement
	| ClassDeclaration 
	| Statement
	;

LocalVariableDeclarationStatement
	: LocalVariableDeclaration ';'
	;

LocalVariableDeclaration
	: UnannType VariableDeclaratorList
	| VariableModifiers UnannType VariableDeclaratorList
	;
	
VariableModifiers 
	: Modifier 
	| Modifier VariableModifiers
	;

Modifiers
	: /* empty */											{ $$ = new System.Collections.Generic.List<AST.Modifier>(); }
	| Modifier Modifiers									{ $$ = $2; $$.Add($1); }
	;

Modifier
	: Public												{ $$ = AST.Modifier.Public; }
	| Protected												{ $$ = AST.Modifier.Protected; }
	| Final													{ $$ = AST.Modifier.Final; }
	| Static												{ $$ = AST.Modifier.Static; }
	;

UnannType
	: UnannPrimitiveType									{ $$ = $1; }
	| UnannReferenceType									{ $$ = $1; }
	;

UnannPrimitiveType	
	: NumericType											{ $$ = $1; }
	| Boolean
	;

NumericType
	: Int													
	;

VariableDeclaratorList
	: VariableDeclarator Comma_VariableDeclarator_opt
	;

Comma_VariableDeclarator_opt
	: /* empty */
	| ',' VariableDeclarator Comma_VariableDeclarator_opt
	;

VariableDeclarator
	: VariableDeclaratorId
	| VariableDeclaratorId '=' VariableInitializer
	;

VariableInitializer
	: Expression 
	//| ArrayInitializer
	;

Statement
	: Assignment ';' 
	;
	
Assignment
	: LeftHandSide AssignmentOperator Expression
	;

LeftHandSide
	: ExpressionName
	;

AssignmentOperator
	: '='
	;

Expression
	: AssignmentExpression
	;

AssignmentExpression
	: Literal 
	| Assignment
	;

Literal
	: IntegerLiteral
	;

ExpressionName
	: Identifier
	;

Result
	: Void													{ $$ = new AST.VoidType(); }
	| UnannType 
	;

MethodDeclarator
	: Identifier '(' FormalParameterList ')' Dims_opt		{ $$ = new AST.MethodDeclarator($1, $3); }
	;

FormalParameterList
	: /* empty */											{ $$ = new System.Collections.Generic.List<AST.Parameter>(); }
	| FormalParameter FormalParameterList					{ $$ = $2; $$.Add($1); }
	;

FormalParameter
	: Modifiers UnannType VariableDeclaratorId				{ $$ = new AST.FormalParameter($1, $3); }
	;

UnannReferenceType
	: UnannArrayType										{ $$ = $1; }
	;

UnannArrayType
	: UnannTypeVariable Dims								{ $$ = new AST.IdentifierType($1); }
	;

UnannTypeVariable
	: Identifier											{ $$ = $1; }
	;

VariableDeclaratorId
	: Identifier Dims_opt									{ $$ = new AST.VariableDeclaration(new AST.IdentifierType($1), $1); }
	;

Dims_opt
	: /* empty */
	| Dims
	;

Dims
	: '[' ']'
	| '[' ']' Dims
	;

%%

public Parser(Scanner scanner) : base(scanner)
{
}