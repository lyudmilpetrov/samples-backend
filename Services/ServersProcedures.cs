using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace samples.Services
{
    public class ServersProcedures
    {
        int tryings = 2;
        int sleeptime = 2000;
        public string PutDataTableWithArrayToDb(ref DataTable dt, string c, Boolean init, string TableName, int processcount, string sql)
        {

            int trynow = 0;
            int multiplicator = 1;
            ///////// recreate table here

            if (init == true)
            {

                return CreateDataTableInServer(ref dt, c, TableName);
            }
            else
            {
            //////////////// // //Trace.WriteLine("!!!!!!!");
            label:
                trynow++;
                if (dt.Rows.Count > 0)
                {
                    // create and open connection object
                    OracleConnection Conn = new OracleConnection(c);
                    Conn.Close();
                    Conn.Open();
                    try
                    {

                        ////http://www.oracle.com/technetwork/issue-archive/2009/09-sep/o59odpnet-085168.html
                        OracleCommand cmd = Conn.CreateCommand();
                        //////// Dictionary<string, dynamic> d = new Dictionary<string, dynamic>();
                        int arr_counter = 0;
                        string sql_command = "INSERT /*+ NOLOGGING PARALLEL(p,21) */ INTO " + TableName + " p (";
                        string temp_sql_command_coloumns = "";
                        string temp_sql_command_arraies = " VALUES (";
                        foreach (DataColumn col in dt.Columns)
                        {
                            arr_counter++;
                            OracleParameter orac_p = new OracleParameter();
                            temp_sql_command_coloumns = temp_sql_command_coloumns + "\"" + col.ColumnName.ToString() + "\"" + ",";
                            temp_sql_command_arraies = temp_sql_command_arraies + ":" + arr_counter + ", ";
                            // //////////////// // //Trace.WriteLine(col.DataType.FullName.ToString().ToUpper());
                            //string[] stringTest = dt.AsEnumerable().Select(r => r.Field<string>(col.ColumnName.ToString())).ToArray();
                            switch (col.DataType.FullName.ToString().ToUpper())
                            {
                                case "SYSTEM.STRING":
                                    string[] stringArrStr = dt.AsEnumerable().Select(r => r.Field<string>(col.ColumnName.ToString())).ToArray();
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrStr, Formatting.Indented));
                                    orac_p.OracleDbType = OracleDbType.Varchar2;
                                    orac_p.Value = stringArrStr;
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrStr.Length;
                                    }
                                    break;
                                case "SYSTEM.DATETIME":
                                    DateTime?[] stringArrDateTime = dt.AsEnumerable().Select(r => r.Field<DateTime?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Date;
                                    orac_p.Value = stringArrDateTime;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrDateTime, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrDateTime.Length;
                                    }
                                    break;
                                case "SYSTEM.INT16":
                                    Int16?[] stringArrInt16 = dt.AsEnumerable().Select(r => r.Field<Int16?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Int16;
                                    orac_p.Value = stringArrInt16;
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrInt16.Length;
                                    }
                                    break;
                                case "SYSTEM.INT32":
                                    Int32?[] stringArrInt32 = dt.AsEnumerable().Select(r => r.Field<Int32?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Int32;
                                    orac_p.Value = stringArrInt32;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrInt32, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrInt32.Length;
                                    }
                                    break;
                                case "SYSTEM.INT64":
                                    Int64?[] stringArrInt64 = dt.AsEnumerable().Select(r => r.Field<Int64?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Int64;
                                    orac_p.Value = stringArrInt64;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrInt64, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrInt64.Length;
                                    }
                                    break;
                                case "SYSTEM.DOUBLE":
                                    Double?[] stringArrDouble = dt.AsEnumerable().Select(r => r.Field<Double?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Double;
                                    orac_p.Value = stringArrDouble;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrDouble, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrDouble.Length;
                                    }
                                    break;
                                case "SYSTEM.DECIMAL":
                                    Decimal?[] stringArrDecimal = dt.AsEnumerable().Select(r => r.Field<Decimal?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Decimal;
                                    orac_p.Value = stringArrDecimal;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrDecimal, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrDecimal.Length;
                                    }
                                    break;
                                case "SYSTEM.SINGLE":
                                    Single?[] stringArrSingle = dt.AsEnumerable().Select(r => r.Field<Single?>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Decimal;
                                    orac_p.Value = stringArrSingle;
                                    ////////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrSingle, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrSingle.Length;
                                    }
                                    break;
                                default:
                                    string[] stringArrStrDef = dt.AsEnumerable().Select(r => r.Field<string>(col.ColumnName.ToString())).ToArray();
                                    orac_p.OracleDbType = OracleDbType.Varchar2;
                                    orac_p.Value = stringArrStrDef;
                                    // //////////////// // //Trace.WriteLine(JsonConvert.SerializeObject(stringArrStrDef, Formatting.Indented));
                                    if (arr_counter == 1)
                                    {
                                        cmd.ArrayBindCount = stringArrStrDef.Length;
                                    }
                                    break;
                            }
                            cmd.Parameters.Add(orac_p);
                        }
                        sql_command = sql_command + temp_sql_command_coloumns;
                        sql_command = sql_command.Substring(0, sql_command.Length - 1) + ")";
                        sql_command = sql_command + temp_sql_command_arraies;
                        sql_command = sql_command.Substring(0, sql_command.Length - 2) + ")";
                        cmd.CommandText = sql_command;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        Conn.Close();
                        Conn.Dispose();
                        return "t";
                    }
                    catch (Exception ex)
                    {
                        if (trynow < (tryings * multiplicator))
                        {
                            goto label;
                        }
                        else
                        {
                            //// // //Trace.WriteLine(ex.Message);
                            //// // //Trace.WriteLine("------" + trynow + " Retrial --------");
                            //// // //Trace.WriteLine(sql);
                            Conn.Close();
                            Conn.Dispose();
                            ////// // //Trace.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! EXCEEDED !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            ////// // //Trace.WriteLine("Try ReadCsvFileToServerOneColumn but create new process that further devides itself");
                            ////// // //Trace.WriteLine("Issue! Table counter - " + dt.Rows.Count);
                            return ex.Message;
                        }
                    }
                }
                return "done";
            }
        }
        public string CreateDataTableInServer(ref DataTable dt, string c, string TableName)
        {
            ////////// // //Trace.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!! INSIDE");
            int trynow = 0;
            string ReturnInfo = "f";
            string procedureStr = "CREATETABLEFROMMIDLAYER";
            string tablename = TableName;
            string options = "";
            foreach (DataColumn col in dt.Columns)
            {
                options = options + col.ColumnName.ToString() + ":" + col.DataType.FullName.ToString() + "|";
            }
            ////////// // //Trace.WriteLine(options);
            OracleConnection Conn = new OracleConnection(c);
            OracleCommand OraCommand = Conn.CreateCommand();
            OraCommand.CommandText = procedureStr;
            OraCommand.CommandType = CommandType.StoredProcedure;
            OraCommand.Parameters.Add(new OracleParameter("tablename", OracleDbType.Varchar2)).Value = tablename;
            OraCommand.Parameters.Add(new OracleParameter("options", OracleDbType.Varchar2)).Value = options;
        label:
            trynow++;
            try
            {
                Conn.Open();
                ////////// // //Trace.WriteLine("Table creation started ");
                OraCommand.ExecuteNonQuery();
                ReturnInfo = "t";
                ////////// // //Trace.WriteLine("Table created");
                Conn.Close();
                Conn.Dispose();
            }
            catch (Exception ex)
            {
                /////////// // //Trace.WriteLine(ex.Message);
                Conn.Close();
                if (trynow < tryings)
                {
                    Thread.Sleep(sleeptime);
                    goto label;
                }
                else
                {
                    return ex.Message;
                }
            }
            return ReturnInfo;
        }
        public static string WriteDataTableToCSVImprove(string filepath, ref DataTable dt, string seperator)
        {
            try
            {
                //DateTime StartTime = DateTime.Now;
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }
                StreamWriter sw = new StreamWriter(filepath, false);
                using (sw)
                {
                    //This Block of code for getting the Table Headers
                    sw.WriteLine(string.Join(seperator, dt.Columns.Cast<DataColumn>().Select(cn => cn.ColumnName)));
                    // Now write all the rows.
                    foreach (DataRow dr in dt.Rows)
                    {
                        sw.Write(string.Join(seperator, dr.ItemArray.Select(p => String.Format("{0}", p).Replace(seperator, "")).ToArray()) + seperator);
                        sw.Write(sw.NewLine);
                    }
                    sw.Close();
                    //Trace.WriteLine(Convert.ToInt32((DateTime.Now - StartTime).TotalSeconds));
                    return "t";
                }

            }
            catch
            {
                return "f";
            }
        }
    }
}
