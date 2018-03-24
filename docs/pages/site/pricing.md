---
permalink: pricing
---

<!-- validation !-->
<div id="error_validation" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="modal_agreement" aria-hidden="true">
	<div class="modal-dialog" role="document">
		<div class="modal-content">
			<div class="modal-header">
				<h4 class="modal-title" id="modal_agreement">License Agreement</h4>
			</div>
			<div class="modal-body bg-danger">
				You must read and agree to the License Agreement.
			</div>
			<div class="modal-footer">
				<button type="button" class="btn btn-z" data-dismiss="modal">Close</button>
			</div>
		</div>
	</div>
</div>


<div class="container">
	<div class="row mt-5">
		<div class="col-lg-7 purchasing-step wow slideInLeft">
			<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top" onsubmit="return purchase_validate()">
				<input type="hidden" name="cmd" value="_s-xclick">
				<input type="hidden" name="currency_code" value="USD">
				<input type="hidden" name="on0" value="Seats">
				
				<div class="hidden-lg-up">
					<h2>Step 1 - Choose License</h2>
					<div class="step-1">
						<div class="form-group">
							<label class="form-label form-label-lg">Which provider?:</label> 
							<select id="provider_type" name="hosted_button_id" class="form-control" onchange="selectProduct()">
								<option value="TSCGQDC4YR2MQ">ALL Providers</option>	
								<option value="GS977QXB98R2C" selected>SQL Server & SQL Azure</option>												
								<option value="32JM43GUXW4ZW">MySQL</option>
								<option value="27ML36DSMHEQA">Oracle</option>
								<option value="TSCZ2KCM9QBVY">PostgreSQL</option>
								<option value="55WDUT7ENJBKU">SQLite</option>
								<option value="5WVPWVNDGRHH6">SQL Compact</option>				
							</select> 
						</div>
						<label class="form-label form-label-lg">For how many developpers?:</label> 
						<select id="product_option" name="os0" class="form-control">
							<option id="seat1" value="1 seat">Entity Framework Extensions $599 (1 developer seat)</option>
							<option id="seat2_4" value="2-4 seats" selected>Entity Framework Extensions $799 (2-4 developer seats)</option>
							<option id="seat5_9" value="5-9 seats">Entity Framework Extensions $999 (5-9 developer seats)</option>
							<option id="seat10_14" value="10-14 seats">Entity Framework Extensions $1199 (10-14 developer seats)</option>
							<option id="seat15_19" value="15-19 seats">Entity Framework Extensions $1399 (15-19 developer seats)</option>
						</select> 
					</div>
					<br />
					<h2>Step 2 - Purchase</h2>
				</div>

				<div class="hidden-md-down">
					<h2>Which provider?</h2>
					<div class="form-group container">
						<div class="row">
							<label class="container_radio col">
								<input type="radio" checked="checked" name="provider" value="GS977QXB98R2C" onclick="calculatePrice()">
								<span class="checkmark btn btn-main-provider sql_only"><span class="icon_check"><i class="fa fa-check-circle" aria-hidden="true"></i></span>SQL Server<br>
								<div class="small_caract">(Include SQL Azure)</div>
								</span>
							</label>
							<label class="container_radio col">
								<input type="radio" name="provider" value="TSCGQDC4YR2MQ" onclick="calculatePrice()">
								<span class="checkmark btn btn-main-provider">
									<span class="icon_check"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									ALL Providers<br>
									<div class="small_caract">(MySQL - Oracle - PostgreSQL <br> SQLite - SQL Compact)</div>
								</span>
							</label>
						</div>
						<a id="other_options" data-toggle="collapse" href="#secondary_providers" role="button" aria-expanded="false" aria-controls="secondary_providers">
							Other options <i class="fa fa-angle-down" aria-hidden="true"></i>
						</a>
						<div id="secondary_providers" class="collapse">
							<div class="row">
								<label class="container_radio col ">
									<input type="radio" name="provider" value="32JM43GUXW4ZW" onclick="calculatePrice()">
									<span class="checkmark btn btn-secondary-provider">
										<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
										MySQL
									</span>
								</label>
								<label class="container_radio col ">
									<input type="radio" name="provider" value="27ML36DSMHEQA" onclick="calculatePrice()">
									<span class="checkmark btn btn-secondary-provider">
										<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
										Oracle
									</span>
								</label>
								<label class="container_radio col ">
									<input type="radio" name="provider" value="TSCZ2KCM9QBVY" onclick="calculatePrice()">
									<span class="checkmark btn btn-secondary-provider">
										<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
										PostgreSQL
									</span>
								</label>
								<label class="container_radio col ">
									<input type="radio" name="provider" value="55WDUT7ENJBKU" onclick="calculatePrice()">
									<span class="checkmark btn btn-secondary-provider">
										<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
										SQLite
									</span>
								</label>
								<label class="container_radio col ">
									<input type="radio" name="provider" value="5WVPWVNDGRHH6" onclick="calculatePrice()">
									<span class="checkmark btn btn-secondary-provider">
										<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
										SQL Compact
									</span>
								</label>
							</div>
						</div>
						<h2 class="mt-4">For how many developpers?</h2>
						<div class="row">
							<label class="container_radio col ">
								<input type="radio" name="seat" value="1 seat" onclick="calculatePrice()">
								<span class="checkmark btn btn-secondary-provider">
									<i class="fa fa-user" aria-hidden="true"></i><br>
									<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									1
								</span>
							</label>
							<label class="container_radio col ">
								<input type="radio" checked="checked" value="2-4 seats" name="seat" onclick="calculatePrice()">
								<span class="checkmark btn btn-secondary-provider">
									<div class="icon_people">
										<i class="fa fa-user bigger" aria-hidden="true"></i>
										<i class="fa fa-user" aria-hidden="true"></i>
									</div>
									<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									2 to 4
								</span>
							</label>
							<label class="container_radio col ">
								<input type="radio" name="seat" value="5-9 seats" onclick="calculatePrice()">
								<span class="checkmark btn btn-secondary-provider">
									<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									<div class="icon_people">
										<i class="fa fa-user" aria-hidden="true"></i>
										<i class="fa fa-user bigger" aria-hidden="true"></i>
										<i class="fa fa-user" aria-hidden="true"></i>
									</div>
									5 to 9
								</span>
							</label>
							<label class="container_radio col ">
								<input type="radio" name="seat" value="10-14 seats" onclick="calculatePrice()">
								<span class="checkmark btn btn-secondary-provider">
									<div class="icon_people">
										<i class="fa fa-user smaller" aria-hidden="true"></i>
										<i class="fa fa-user" aria-hidden="true"></i>
										<i class="fa fa-user bigger" aria-hidden="true"></i>
										<i class="fa fa-user bigger" aria-hidden="true"></i>
									</div>
									<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									10 to 14
								</span>
							</label>
							<label class="container_radio col ">
								<input type="radio" name="seat" value="15-19 seats" onclick="calculatePrice()">
								<span class="checkmark btn btn-secondary-provider">
									<div class="icon_people">
										<i class="fa fa-user smaller" aria-hidden="true"></i>
										<i class="fa fa-user" aria-hidden="true"></i>
										<i class="fa fa-user bigger" aria-hidden="true"></i>
										<i class="fa fa-user" aria-hidden="true"></i>
										<i class="fa fa-user smaller" aria-hidden="true"></i>
									</div>
									<span class="icon_check small"><i class="fa fa-check-circle" aria-hidden="true"></i></span>
									15 to 19
								</span>
							</label>
						</div> 
						<div class="price separator">
							<span class="text"><span id="productPrice">799</span><sup>$</sup></span>
							<span class="line"></span>
						</div>
					</div>

				</div>
				<div class="checkbox">
					<label>
						<input id="agree_agreement" type="checkbox">&nbsp;I have read and agree to the <a href="http://www.zzzprojects.com/license-agreement/" target="_blank">License Agreement</a>
					</label>
				</div>
				<br />
				<button type="submit" class="btn btn-paypal btn-lg w-100" onclick="ga('send', 'event', { eventAction: 'buy-now'});">
					<i class="fa fa-paypal" aria-hidden="true"></i> BUY NOW
				</button>
				<div class="more-option">*&nbsp;Read the FAQ below for alternative payment method.</div>				
			</form>
		</div>
		<div class="col-lg-5 wow slideInRight section_trial">
			<h2>Not convinced yet?</h2>
			<a href="/download" class="btn btn-z"><i class="fa fa-cloud-download" aria-hidden="true"></i> Download free trial</a>
			<p>The trial can be extended for several months by downloading the latest version at the beginning of every month.</p>
			<div class="boxes">
				The license include:
				<ul class="list-checked">
					<li> All bulk extensions methods</li>
					<li> Commercial License</li>
					<li> Royalty-Free</li>
					<li> Perpetual Licenses</li>
					<li> Support & Upgrades (1 year)</li>
				</ul>
			</div>
			<div class="boxes">
				<h3>Question</h3>
				<p>Contact us: {% include mail-sales.html %}</p>
			</div>
		</div>
	</div>
</div>

---

<div class="container section-faq wow slideInLeft">
{% include section-faq-begin.html %}

## FAQ

### Which payment alternative methods are accepted?
We accept `PayPal`, `Cheque` and `Wire Transfer`.

We **DO NOT** accept bitcoins and credit cards.

Please contact us for more information.

Email: <a href="mailto:sales@zzzprojects.com">sales@zzzprojects.com</a>

### Do you accept resellers?
Yes contact us if you are a reseller or seeking for a reseller.

Email: <a href="mailto:sales@zzzprojects.com">sales@zzzprojects.com</a>

### What 2-4 developer seats mean?
It mean that you can use the license with up to 4 developers inside your team.

The `5-9` developer seats mean you can use the license with up 9 developers.

You only pay for developer seats. You can use our library with an unlimited amount of applications, environments, servers, and client machines.

### I need more than 19 seats, what can I do?
Please contact us with the number of seats required. We offer some additional discounts or enterprise licenses.

Email: <a href="mailto:sales@zzzprojects.com">sales@zzzprojects.com</a>

### Is the license perpetual?
The product comes with one year of support & upgrades but the license is perpetual (indefinitely useable). So you are not obligated to renew every year or renew at all.

Renewing comes with a lot of benefits such as a 25%/35%/50% discount on purchased price, discounted or free products, etc.

### Why isn't this library free and open source?
`ZZZ Projects` mission is focused on adding value to the `.NET Community` and supporting a lot of `free and open source` libraries.

However, this mission cannot be successful without being able to pay our developers for the time they pass to support & develop features for free and paid libraries.

#### Free Librairies

- [Html Agility Pack](http://html-agility-pack.net/){:target="_blank"}
- [Entity Framework Plus](http://entityframework-plus.net/){:target="_blank"}
- [Entity Framework DynamicFilter](https://github.com/zzzprojects/EntityFramework.DynamicFilters){:target="_blank"}
- [RefactorThis.GraphDiff](https://github.com/zzzprojects/GraphDiff){:target="_blank"}
- [Extension Methods](https://github.com/zzzprojects/Z.ExtensionMethods){:target="_blank"}

#### Website

- [.NET Fiddle](https://dotnetfiddle.net/){:target="_blank"}
- [SQL Fiddle](http://sqlfiddle.com/){:target="_blank"}
- [NuGet Must Haves](http://nugetmusthaves.com/){:target="_blank"}
- [Dapper Tutorial](http://dapper-tutorial.net/){:target="_blank"}

By contributing on paid libraries, you are also helping in keeping other libraries and website FREE.

{% include section-faq-end.html %}
</div>

<script>
function purchase_validate() {
	if($("#agree_agreement").prop('checked')) {
		return true;
	}

	$("#error_validation").modal('show')
	return false;
}
function calculatePrice() {
	var provider = $('input[name="provider"]:checked').val();
	var seat = $('input[name="seat"]:checked').val();

	$("#provider_type").val(provider);
	selectProduct();
	$("#product_option").val(seat); 

	var provider_type = $("#provider_type").find(":selected").index();
	var product_option = $("#product_option").find(":selected").index();
	
	
	var price = 599;

	if(provider_type == 0) {
		price += 200;
	}
	price += product_option * 200;

	$("#productPrice").html(price);
}
function selectProduct() {
	if($("#provider_type").val() == "TSCGQDC4YR2MQ") {
		$("#seat1").html("Entity Framework Extensions $799 (1 developer seat)");
		$("#seat2_4").html("Entity Framework Extensions $999 (2-4 developer seats)");
		$("#seat5_9").html("Entity Framework Extensions $1199 (5-9 developer seats)");
		$("#seat10_14").html("Entity Framework Extensions $1399 (10-14 developer seats)");
		$("#seat15_19").html("Entity Framework Extensions $1599 (15-19 developer seats)");
	}
	else {
		$("#seat1").html("Entity Framework Extensions $599 (1 developer seat)");
		$("#seat2_4").html("Entity Framework Extensions $799 (2-4 developer seats)");
		$("#seat5_9").html("Entity Framework Extensions $999 (5-9 developer seats)");
		$("#seat10_14").html("Entity Framework Extensions $1199 (10-14 developer seats)");
		$("#seat15_19").html("Entity Framework Extensions $1399 (15-19 developer seats)");
	}
}

</script>