---
layout: default
title: Entity Framework Extensions - API
permalink: api
---

{% include template-h1.html %}

## Article

_Under Construction! Examples will be available soon._

<ul>
{% for num in (0..site.data.permalink.size) %}	
	{% if site.data.permalink[num].category == page.permalink %}
		<li><a href="{{ site.data.permalink[num].permalink }}">{{ site.data.permalink[num].permalink }}</a></li>
	{% endif %}
{% endfor %}
</ul>
