using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4.Final.Class;
using d7p4n4.PreProcessed.Class;

namespace d7p4n4.Algebra.Class
{
	public class Ac4yAlgebra : Ac4yPreProcessed
	{

		public String getSerialization() {
        		return serialization;
        }

		public Ac4yIdentificationBase getTemplate() {
        		return template;
        }

    		public void setSerialization(String newValue) {
        		serialization = newValue;
        }

    		public void setTemplate(Ac4yIdentificationBase newValue) {
        		template = newValue;
        }

		public Boolean hasSerialization(){
			if(this.getSerialization() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasTemplate(){
			if(this.getTemplate() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
