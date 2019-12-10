// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi
{
	///<summary>
	/// Snapshot Lifecycle Management APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.SnapshotLifecycleManagement"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelSnapshotLifecycleManagementNamespace : NamespacedClientProxy
	{
		internal LowLevelSnapshotLifecycleManagementNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy to remove</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteSnapshotLifecycle<TResponse>(string policyId, DeleteSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_slm/policy/{policyId:policyId}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy to remove</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.delete_lifecycle", "policy_id")]
		public Task<TResponse> DeleteSnapshotLifecycleAsync<TResponse>(string policyId, DeleteSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_slm/policy/{policyId:policyId}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_slm/policy/{policy_id}/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy to be executed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ExecuteSnapshotLifecycle<TResponse>(string policyId, ExecuteSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_slm/policy/{policyId:policyId}/_execute"), null, RequestParams(requestParameters));
		///<summary>PUT on /_slm/policy/{policy_id}/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy to be executed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.execute_lifecycle", "policy_id")]
		public Task<TResponse> ExecuteSnapshotLifecycleAsync<TResponse>(string policyId, ExecuteSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_slm/policy/{policyId:policyId}/_execute"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_slm/_execute_retention <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ExecuteRetentionSnapshotLifecycle<TResponse>(ExecuteRetentionSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_slm/_execute_retention", null, RequestParams(requestParameters));
		///<summary>POST on /_slm/_execute_retention <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.execute_retention", "")]
		public Task<TResponse> ExecuteRetentionSnapshotLifecycleAsync<TResponse>(ExecuteRetentionSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_slm/_execute_retention", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</para></summary>
		///<param name = "policyId">Comma-separated list of snapshot lifecycle policies to retrieve</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSnapshotLifecycle<TResponse>(string policyId, GetSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_slm/policy/{policyId:policyId}"), null, RequestParams(requestParameters));
		///<summary>GET on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</para></summary>
		///<param name = "policyId">Comma-separated list of snapshot lifecycle policies to retrieve</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.get_lifecycle", "policy_id")]
		public Task<TResponse> GetSnapshotLifecycleAsync<TResponse>(string policyId, GetSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_slm/policy/{policyId:policyId}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_slm/policy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSnapshotLifecycle<TResponse>(GetSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_slm/policy", null, RequestParams(requestParameters));
		///<summary>GET on /_slm/policy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.get_lifecycle", "")]
		public Task<TResponse> GetSnapshotLifecycleAsync<TResponse>(GetSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_slm/policy", ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy</param>
		///<param name = "body">The snapshot lifecycle policy definition to register</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutSnapshotLifecycle<TResponse>(string policyId, PostData body, PutSnapshotLifecycleRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_slm/policy/{policyId:policyId}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_slm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put.html</para></summary>
		///<param name = "policyId">The id of the snapshot lifecycle policy</param>
		///<param name = "body">The snapshot lifecycle policy definition to register</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("slm.put_lifecycle", "policy_id, body")]
		public Task<TResponse> PutSnapshotLifecycleAsync<TResponse>(string policyId, PostData body, PutSnapshotLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_slm/policy/{policyId:policyId}"), ctx, body, RequestParams(requestParameters));
	}
}