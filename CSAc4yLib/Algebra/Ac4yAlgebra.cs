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

		public String getGUID() {
        		return GUID;
        }

		public String getHumanId() {
        		return HumanId;
        }

		public String getPublicHumanId() {
        		return PublicHumanId;
        }

		public Int32 getId() {
        		return id;
        }


    		public void setSerialization(String newValue) {
        		serialization = newValue;
        }

    		public void setTemplate(Ac4yIdentificationBase newValue) {
        		template = newValue;
        }

    		public void setGUID(String newValue) {
        		GUID = newValue;
        }

    		public void setHumanId(String newValue) {
        		HumanId = newValue;
        }

    		public void setPublicHumanId(String newValue) {
        		PublicHumanId = newValue;
        }

    		public void setId(Int32 newValue) {
        		id = newValue;
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

		public Boolean hasGUID(){
			if(this.getGUID() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasHumanId(){
			if(this.getHumanId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasPublicHumanId(){
			if(this.getPublicHumanId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
