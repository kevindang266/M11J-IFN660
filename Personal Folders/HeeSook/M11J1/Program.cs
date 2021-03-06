﻿using System;
using System.Collections.Generic;
using System.IO;
using M11J1.AST;

namespace M11J1
{
    class Program
    {



        static void Main(string[] args)
        {
         //   var filename = @"..\..\Tests\m11j1.java";
            // Scanner scanner = new Scanner(
            //     new FileStream(filename, FileMode.Open));
            // Parser parser = new Parser(scanner);
            if (args[0]==null)
            {
                Console.WriteLine(" EXE file1(Source) File2(ILCode)...");
                return;
            }
            Scanner scanner = new Scanner(
                new FileStream(args[0], FileMode.Open));


            Parser parser = new Parser(scanner);

            parser.Parse();

            if (Parser.Root != null)
            {
                SemanticAnalysis(Parser.Root);
                //Parser.Root.Dump(0);
                if (args[1] == null)
                {
                    Console.WriteLine(" EXE file1(Source) File2(ILCode)...");
                    return;
                }
                CodeGeneration(args[1], Parser.Root);
                Console.WriteLine("Created "+ args[1]);
            }
            else
            {

                Console.WriteLine(".....");
            }

           // ASTHardCodeTest();
            
           // Console.ReadLine();
        }


        public static void CodeGeneration(string outputFile, Node root)
        {
           // Console.WriteLine(outputFile);
            //string path = Directory.GetCurrentDirectory();
            //string outputFile = path + @"\test.il";
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }

            root.GenCode(outputFile);

            root.Emit(outputFile, "ret");
            root.Emit(outputFile, "}}");
            root.Emit(outputFile, "}}");



  
        }

        public static void SemanticAnalysis(Node root)
        {
            root.ResolveNames(null);
            root.TypeCheck();
        }

        public static void ASTHardCodeTest()
        {
            var pro = new CompilationUnit(
                new ClassDeclaration(
                    new List<Modifier> {Modifier.Public},
                    "HelloWorld",
                    new List<MethodDeclaration>
                    {
                        new MethodDeclaration(
                            new List<Modifier> {Modifier.Public, Modifier.Static},
                            new MethodHeader(new VoidType(),
                                new MethodDeclarator("main",
                                    new List<Parameter> {new FormalParameter(null, new IdentifierType(), "args")}
                                )
                            ),
                            new CompoundStatement(
                                new List<Statement>
                                {
                                    new VariableDeclarationList(
                                        new List<VariableDeclaration> {new VariableDeclaration(new IntType(), "x")}
                                    ),
                                    new VariableDeclarationList(
                                        new List<VariableDeclaration> {new VariableDeclaration(new IntType(), "y")}
                                    ),
                                    new ExpressionStatement(
                                        new AssignmentExpression(
                                            new IdentifierExpression("x"),
								                 '=',
                                            new NumberExpression(42)
                                        )
                                    ),
                                }
                            )
                        )
                    }
                )
            );
            
            SemanticAnalysis(pro);
            pro.Dump(0);
        }
    }
    class Global
    {
        public static long LastLabel = 0;
        public static int LastLocal = 0;

        public static string GetLabel()
        {
            return string.Format("{0}{1:x4}{2}", "IL_", LastLabel++, ":");
        }
    }
}
