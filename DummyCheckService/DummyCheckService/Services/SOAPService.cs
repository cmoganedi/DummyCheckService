﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyCheckService.Services
{
    public class SOAPService
    {
        public string TherestResponse()
        {
            return otherxml;
        }
        public string RompuscanResponse()
        {
            return soapText;
        }
        private static readonly string otherxml =
        @"<date>2019-03-14</date>
        <name>Sphelele</name>
        <identity>880201025452082</identity>
        <whips></whips>
        <somedata></somedata>";

        private static readonly string soapText =
        @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:web=""http://webServices/"">
        <soapenv:Header/>
        <soapenv:Body>
        <web:DoNormalEnquiry>
        <!--Optional:-->    
        <request>
        <pUsrnme>77985-1</pUsrnme>
        <pPasswrd>devtest</pPasswrd>
        <pVersion>1.0</pVersion>
        <pOrigin>CC-SOAPUI</pOrigin>
        <pOrigin_Version>5.2.1</pOrigin_Version>
        <pInput_Format>XML</pInput_Format>
        <pTransaction><![CDATA[<Transactions>
							<Search_Criteria>
								<CS_Data>Y</CS_Data>
								<CPA_Plus_NLR_Data>Y</CPA_Plus_NLR_Data>
								<Deeds_Data>N</Deeds_Data>
								<Directors_Data>N</Directors_Data>
								<Identity_number>8209147250087</Identity_number>
								<Surname>Doe</Surname>
								<Forename>John</Forename>
								<Forename2></Forename2>
								<Forename3></Forename3>
								<Gender>M</Gender>
								<Passport_flag>N</Passport_flag>
								<DateOfBirth>19820914</DateOfBirth>
								<Address1>10 Mars Street</Address1>
								<Address2>Mars</Address2>
								<Address3></Address3>
								<Address4></Address4>
								<PostalCode>1234</PostalCode>
								<HomeTelCode></HomeTelCode>
								<HomeTelNo></HomeTelNo>
								<WorkTelCode></WorkTelCode>
								<WorkTelNo></WorkTelNo>
								<CellTelNo></CellTelNo>
								<ResultType>XPDF2</ResultType>
								<RunCodix>N</RunCodix>
								<CodixParams></CodixParams>
								<Adrs_Mandatory>Y</Adrs_Mandatory>
								<Enq_Purpose>12</Enq_Purpose>
								<Run_CompuScore>Y</Run_CompuScore>
								<ClientConsent>Y</ClientConsent>            
							</Search_Criteria>
						</Transactions>]]>
                    </pTransaction>
        </request>
        </web:DoNormalEnquiry>
        </soapenv:Body>
        </soapenv:Envelope>";
    }
}
